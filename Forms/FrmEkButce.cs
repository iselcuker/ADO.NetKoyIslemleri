using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmEkButce : Form
    {
        public FrmEkButce()
        {
            InitializeComponent();
        }

        private void pcKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctEkGelir_Click(object sender, EventArgs e)
        {
            FrmEkGelir frmEkGelir = new FrmEkGelir();
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)this.ParentForm;

            frmEkGelir.TopLevel = false;
            frmEkGelir.FormBorderStyle = FormBorderStyle.None;
            frmEkGelir.Dock = DockStyle.Fill;
            frmAnaSayfa.pnlEkran.Controls.Clear();
            frmAnaSayfa.pnlEkran.Controls.Add(frmEkGelir);
            frmEkGelir.Show();
        }

        private void pctEkGider_Click(object sender, EventArgs e)
        {
            FrmEkGider frmEkGider = new FrmEkGider();
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)this.ParentForm;

            frmEkGider.TopLevel = false;
            frmEkGider.FormBorderStyle = FormBorderStyle.None;
            frmEkGider.Dock = DockStyle.Fill;
            frmAnaSayfa.pnlEkran.Controls.Clear();
            frmAnaSayfa.pnlEkran.Controls.Add(frmEkGider);
            frmEkGider.Show();
        }
    }
}
