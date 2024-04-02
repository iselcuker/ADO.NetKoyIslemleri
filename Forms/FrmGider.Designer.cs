namespace Forms
{
    partial class FrmGider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGider));
            label3 = new Label();
            label2 = new Label();
            cmbGiderKategori = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTutar = new TextBox();
            txtAlan = new TextBox();
            txtEvrakNo = new TextBox();
            dgvGiderler = new DataGridView();
            mskTarih = new MaskedTextBox();
            pcKapat = new PictureBox();
            label6 = new Label();
            cmbGiderAltKategori = new ComboBox();
            pictureBox3 = new PictureBox();
            pnlSil = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pnlGuncelle = new Panel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            pnlKaydet = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGiderler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // cmbGiderKategori
            // 
            cmbGiderKategori.BackColor = SystemColors.Control;
            cmbGiderKategori.Cursor = Cursors.Hand;
            cmbGiderKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cmbGiderKategori, "cmbGiderKategori");
            cmbGiderKategori.FormattingEnabled = true;
            cmbGiderKategori.Name = "cmbGiderKategori";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // txtTutar
            // 
            txtTutar.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtTutar, "txtTutar");
            txtTutar.Name = "txtTutar";
            // 
            // txtAlan
            // 
            txtAlan.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtAlan, "txtAlan");
            txtAlan.Name = "txtAlan";
            // 
            // txtEvrakNo
            // 
            txtEvrakNo.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtEvrakNo, "txtEvrakNo");
            txtEvrakNo.Name = "txtEvrakNo";
            // 
            // dgvGiderler
            // 
            dgvGiderler.BackgroundColor = SystemColors.Control;
            dgvGiderler.BorderStyle = BorderStyle.Fixed3D;
            dgvGiderler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGiderler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvGiderler, "dgvGiderler");
            dgvGiderler.Name = "dgvGiderler";
            // 
            // mskTarih
            // 
            mskTarih.Cursor = Cursors.IBeam;
            resources.ApplyResources(mskTarih, "mskTarih");
            mskTarih.Name = "mskTarih";
            mskTarih.ValidatingType = typeof(DateTime);
            // 
            // pcKapat
            // 
            pcKapat.Image = Properties.Resources.power;
            resources.ApplyResources(pcKapat, "pcKapat");
            pcKapat.Name = "pcKapat";
            pcKapat.TabStop = false;
            pcKapat.Click += pictureBox1_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // cmbGiderAltKategori
            // 
            cmbGiderAltKategori.BackColor = SystemColors.Control;
            cmbGiderAltKategori.Cursor = Cursors.Hand;
            cmbGiderAltKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cmbGiderAltKategori, "cmbGiderAltKategori");
            cmbGiderAltKategori.FormattingEnabled = true;
            cmbGiderAltKategori.Name = "cmbGiderAltKategori";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label7);
            resources.ApplyResources(pnlSil, "pnlSil");
            pnlSil.Name = "pnlSil";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BorderStyle = BorderStyle.FixedSingle;
            pnlGuncelle.Controls.Add(pictureBox2);
            pnlGuncelle.Controls.Add(label8);
            resources.ApplyResources(pnlGuncelle, "pnlGuncelle");
            pnlGuncelle.Name = "pnlGuncelle";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pictureBox4);
            pnlKaydet.Controls.Add(label10);
            resources.ApplyResources(pnlKaydet, "pnlKaydet");
            pnlKaydet.Name = "pnlKaydet";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // FrmGider
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(pictureBox3);
            Controls.Add(pcKapat);
            Controls.Add(mskTarih);
            Controls.Add(dgvGiderler);
            Controls.Add(txtEvrakNo);
            Controls.Add(txtAlan);
            Controls.Add(txtTutar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmbGiderAltKategori);
            Controls.Add(label6);
            Controls.Add(cmbGiderKategori);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGider";
            ((System.ComponentModel.ISupportInitialize)dgvGiderler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlSil.ResumeLayout(false);
            pnlSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlGuncelle.ResumeLayout(false);
            pnlGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlKaydet.ResumeLayout(false);
            pnlKaydet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDonem;
        private Label label3;
        private ComboBox cmbKoy;
        private Label label2;
        private ComboBox cmbGiderKategori;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtTutar;
        private TextBox txtAlan;
        private TextBox txtEvrakNo;
        private DataGridView dgvGiderler;
        private MaskedTextBox mskTarih;
        private PictureBox pcKapat;
        private Label label6;
        private ComboBox cmbGiderAltKategori;
        private PictureBox pictureBox3;
        private Panel pnlSil;
        private PictureBox pictureBox1;
        private Label label7;
        private Panel pnlGuncelle;
        private PictureBox pictureBox2;
        private Label label8;
        private Panel pnlKaydet;
        private PictureBox pictureBox4;
        private Label label10;
    }
}