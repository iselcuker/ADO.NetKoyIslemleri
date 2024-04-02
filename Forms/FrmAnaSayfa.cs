using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.Design.Behavior;

namespace Forms
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
            IlceleriDoldur();
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            KoylariDoldur();
            DonemleriDoldur();
        }

        SqlBaglantisi bgl = new SqlBaglantisi(); //Sql ile baðlantý yapacak sýnýfý çaðýrýyoruz

        public void Baslik()
        {
            lblBaslik.Text = cmbKoy.Text + " Köyü " + cmbDonem.Text + " Yýlý Ýþlemleri";
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            pnlBaslik.Visible = false;
            cmbKoy.Visible = false;
            lblKoy.Visible = false;
            cmbDonem.Visible = false;
            lblDonem.Visible = false;
            grbNot.Visible = false;
            grpSonDurum.Visible = false;
            pnlButonlar.Visible = false;
            pnlEkran.Visible = false;
        }

        private void IlceleriDoldur()
        {
            using (var baglanti = bgl.baglanti())
            {
                var cmd = new SqlCommand("SELECT IlceAdi FROM Ilces", baglanti);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbIlce.Items.Add(reader["IlceAdi"]);
                }
            }
        }

        private int secilenIlceId;

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKoy.Visible = true;
            lblKoy.Visible = true;
            if (cmbIlce.SelectedIndex == -1) return;

            var secilenIlce = cmbIlce.SelectedItem.ToString();

            using (var baglanti = bgl.baglanti())
            {
                var cmd = new SqlCommand(
                    @"SELECT KoyAdi FROM Koys
                WHERE IlceId = (SELECT Id FROM Ilces WHERE IlceAdi = @ilceAdi)", baglanti);

                cmd.Parameters.AddWithValue("@ilceAdi", secilenIlce);

                cmbKoy.Items.Clear();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbKoy.Items.Add(reader["KoyAdi"]);
                }
            }
        }

        public void KoylariDoldur()
        {
            cmbKoy.Items.Clear();

            using (var baglanti = bgl.baglanti())
            {
                var cmd = new SqlCommand(
                    @"SELECT KoyAdi FROM Koys
            WHERE IlceId = @ilceId", baglanti);

                cmd.Parameters.AddWithValue("@ilceId", secilenIlceId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbKoy.Items.Add(reader["KoyAdi"]);
                }
            }
        }

        private void cmbKoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDonem.Visible = true;
            lblDonem.Visible = true; ;
        }

        public void DonemleriDoldur()
        {
            using (var baglanti = bgl.baglanti())
            {
                var cmd = new SqlCommand("SELECT DonemAdi FROM Donems", baglanti);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbDonem.Items.Add(reader["DonemAdi"]);
                }
            }
        }

        private void cmbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBaslik.Visible = true;
            grbNot.Visible = true;
            grpSonDurum.Visible = true;
            pnlButonlar.Visible = true;
            pnlEkran.Visible = true;
        }

        private void pnlGelir_Paint(object sender, PaintEventArgs e)
        {



            //GEMÝNÝ KODLARI
            var frmGelir = new FrmGelir();
            frmGelir.TopLevel = false;
            frmGelir.FormBorderStyle = FormBorderStyle.None;
            frmGelir.Dock = DockStyle.Fill;
            pnlEkran.Controls.Clear();
            pnlEkran.Controls.Add(frmGelir);

            // Seçilen deðerlerin alýnmasý
            var secilenKoyId = (int)cmbKoy.SelectedValue;
            var secilenDonemId = (int)cmbDonem.SelectedValue;

            // FrmGelir'deki datagridview'e veri gönderme
            frmGelir.dgvGelirler.DataSource = GelirleriGetir(secilenKoyId, secilenDonemId);

            frmGelir.Show();
        }

        //GEMÝNÝ KODLARI
        private DataTable GelirleriGetir(int koyId, int donemId)
        {
            using (var baglanti = bgl.baglanti())
            {
                var cmd = new SqlCommand(
                    @"SELECT g.Id, g.GelirKategoriId, g.KoyId, g.DonemId, g.Tutar, g.Tarih, g.EvrakNo, g.Veren
            FROM Gelirs g
            WHERE g.KoyId = @koyId AND g.DonemId = @donemId", baglanti);

                cmd.Parameters.AddWithValue("@koyId", koyId);
                cmd.Parameters.AddWithValue("@donemId", donemId);

                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}






