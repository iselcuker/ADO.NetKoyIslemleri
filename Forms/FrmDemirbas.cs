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
    public partial class FrmDemirbas : Form
    {
        public FrmDemirbas()
        {
            InitializeComponent();
            //DemirbasListele();
            //DemirbasYukle();
            
        }

        //SqlBaglantisi bgl=new SqlBaglantisi();

        private void pcKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public void DemirbasListele()
        //{
        //    FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
        //    DataTable dt= new DataTable();
        //    SqlDataAdapter da=new SqlDataAdapter("SELECT \r\n    Demirbas.Id AS DemirbasId,\r\n    Koys.KoyAdi AS KoyAdi,\r\n    Demirbas.DemirbasAdi,\r\n    Demirbas.KimdenAlindi,\r\n    Demirbas.Tutar,\r\n    Demirbas.FaturaTarihi,\r\n    Demirbas.EvrakNo\r\nFROM \r\n    Demirbas\r\nINNER JOIN \r\n    Koys ON Demirbas.KoyId = Koys.Id\r\nWHERE \r\n    Koys.Id = @p1", bgl.baglanti());

        //    da.Fill(dt);
        //    dgvDemirbaslar.DataSource = dt;

        //    bgl.baglanti().Close();
        //}

        // FrmDemirbas.cs dosyasında:
        public void DemirbaslariGetir(string koyAdi)
        {
            
        }

        private void FrmDemirbas_Load(object sender, EventArgs e)
        {
            //dgvDemirbaslar.Columns.Add("Id", "ID");
            //dgvDemirbaslar.Columns.Add("DemirbasAdi", "Demirbas Adı");
            //dgvDemirbaslar.Columns.Add("KimdenAlindi", "Kimden Alındı");
            //dgvDemirbaslar.Columns.Add("Tutar", "Tutar");
            //dgvDemirbaslar.Columns.Add("FaturaTarihi", "Fatura Tarihi");
            //dgvDemirbaslar.Columns.Add("EvrakNo", "Evrak No");
        }


        //public void DemirbasYukle()
        //{
        //    // Seçilen köy adını al
        //    string secilenKoyAdi = cmbKoy.SelectedItem != null ? cmbKoy.SelectedItem.ToString() : "";

        //    // Seçilen köye ait Demirbas verilerini FrmDemirbas formunda göster
        //    FrmDemirbas frmDemirbas = new FrmDemirbas();
        //    frmDemirbas.DemirbaslariGetir(secilenKoyAdi);
        //    frmDemirbas.Show();
        //}


    }
}
