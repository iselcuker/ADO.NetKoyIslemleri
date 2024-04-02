using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmGelir : Form
    {
        
        FrmAnaSayfa frmAnaSayfa=new FrmAnaSayfa();
        SqlBaglantisi bgl = new SqlBaglantisi(); //Sql ile bağlantı yapacak sınıfı çağırıyoruz

       

        public FrmGelir()
        {
            InitializeComponent();
        }

        public FrmGelir(ComboBox cmbKoy, ComboBox cmbDonem)
        {
            InitializeComponent();

          
        }


        private void FrmGelir_Load(object sender, EventArgs e)
        {
            //GEMİNİ KODLARI
            // Field'ı kullan
            dgvGelirler.DataSource = null;
            if (dgvGelirler.DataSource != null)
            {
                dgvGelirler.Columns["Id"].Visible = false;
                dgvGelirler.Columns["GelirKategoriId"].Visible = false;
                dgvGelirler.Columns["KoyId"].Visible = false;
                dgvGelirler.Columns["DonemId"].Visible = false;
            }


        }

        private DataTable GelirleriGetir()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = bgl.baglanti()) // Sql bağlantısını aç
            {
                string query = "SELECT * FROM Gelirs WHERE KoyId = @KoyId AND DonemId = @DonemId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // cmbKoy ve cmbDonem'den seçilen değerleri parametre olarak kullan
                    cmd.Parameters.AddWithValue("@KoyId", frmAnaSayfa.cmbKoy.SelectedValue);
                    cmd.Parameters.AddWithValue("@DonemId", frmAnaSayfa.cmbDonem.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}

