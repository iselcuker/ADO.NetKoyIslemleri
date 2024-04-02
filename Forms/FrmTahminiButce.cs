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
    public partial class FrmTahminiButce : Form
    {
        public FrmTahminiButce()
        {
            InitializeComponent();
        }

        private void pcKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void pctTahminiGelir_Click(object sender, EventArgs e)
        {
            // FrmTahminiGelir formunu oluşturun
            FrmTahminiGelir frmTahminiGelir = new FrmTahminiGelir();

            // FrmAnaSayfa formunu bulun
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)this.ParentForm;

            // FrmAnaSayfa içindeki pnlEkran paneline FrmTahminiGelir formunu yerleştirin
            frmTahminiGelir.TopLevel = false;
            frmTahminiGelir.FormBorderStyle = FormBorderStyle.None;
            frmTahminiGelir.Dock = DockStyle.Fill;
            frmAnaSayfa.pnlEkran.Controls.Clear();
            frmAnaSayfa.pnlEkran.Controls.Add(frmTahminiGelir);
            frmTahminiGelir.Show();
        }

        private void pctTahminiGider_Click(object sender, EventArgs e)
        {
            FrmTahminiGider frmTahminiGider = new FrmTahminiGider();
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)this.ParentForm;
            frmTahminiGider.TopLevel = false;
            frmTahminiGider.FormBorderStyle = FormBorderStyle.None;
            frmTahminiGider.Dock = DockStyle.Fill;
            frmAnaSayfa.pnlEkran.Controls.Clear();
            frmAnaSayfa.pnlEkran.Controls.Add(frmTahminiGider);
            frmTahminiGider.Show();
        }

        private void pctTahiminIdariIsler_Click(object sender, EventArgs e)
        {
            FrmTahminiIdariIsler frmTahminiIdariIsler = new FrmTahminiIdariIsler();
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)this.ParentForm;
            frmTahminiIdariIsler.TopLevel = false;
            frmTahminiIdariIsler.FormBorderStyle = FormBorderStyle.None;
            frmTahminiIdariIsler.Dock = DockStyle.Fill;
            frmAnaSayfa.pnlEkran.Controls.Clear();
            frmAnaSayfa.pnlEkran.Controls.Add(frmTahminiIdariIsler);
            frmTahminiIdariIsler.Show();
        }
    }
}
