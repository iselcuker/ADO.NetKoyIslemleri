namespace Forms
{
    partial class FrmGelir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelir));
            pcKapat = new PictureBox();
            dgvGelirler = new DataGridView();
            cmbGelirKategori = new ComboBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            mskTarih = new MaskedTextBox();
            txtEvrakNo = new TextBox();
            txtVeren = new TextBox();
            txtTutar = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            pnlSil = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlGuncelle = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            pnlKaydet = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGelirler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pcKapat
            // 
            pcKapat.Image = Properties.Resources.power;
            pcKapat.ImeMode = ImeMode.NoControl;
            pcKapat.Location = new Point(835, 0);
            pcKapat.Name = "pcKapat";
            pcKapat.Size = new Size(40, 35);
            pcKapat.SizeMode = PictureBoxSizeMode.StretchImage;
            pcKapat.TabIndex = 29;
            pcKapat.TabStop = false;
            
            // 
            // dgvGelirler
            // 
            dgvGelirler.BackgroundColor = SystemColors.Control;
            dgvGelirler.BorderStyle = BorderStyle.Fixed3D;
            dgvGelirler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGelirler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelirler.Dock = DockStyle.Bottom;
            dgvGelirler.Location = new Point(0, 273);
            dgvGelirler.Name = "dgvGelirler";
            dgvGelirler.Size = new Size(875, 358);
            dgvGelirler.TabIndex = 24;
            // 
            // cmbGelirKategori
            // 
            cmbGelirKategori.BackColor = SystemColors.Control;
            cmbGelirKategori.Cursor = Cursors.Hand;
            cmbGelirKategori.DrawMode = DrawMode.OwnerDrawVariable;
            cmbGelirKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGelirKategori.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbGelirKategori.ForeColor = SystemColors.MenuText;
            cmbGelirKategori.FormattingEnabled = true;
            cmbGelirKategori.Location = new Point(193, 14);
            cmbGelirKategori.Name = "cmbGelirKategori";
            cmbGelirKategori.Size = new Size(396, 34);
            cmbGelirKategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 14.25F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 24);
            label1.TabIndex = 19;
            label1.Text = "Gelir Kategori";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(595, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(225, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // mskTarih
            // 
            mskTarih.Cursor = Cursors.IBeam;
            mskTarih.Font = new Font("Lucida Calligraphy", 14.25F);
            mskTarih.Location = new Point(193, 87);
            mskTarih.Mask = "00/00/0000";
            mskTarih.Name = "mskTarih";
            mskTarih.Size = new Size(97, 33);
            mskTarih.TabIndex = 2;
            mskTarih.ValidatingType = typeof(DateTime);
            // 
            // txtEvrakNo
            // 
            txtEvrakNo.Cursor = Cursors.IBeam;
            txtEvrakNo.Font = new Font("Lucida Calligraphy", 14.25F);
            txtEvrakNo.Location = new Point(193, 159);
            txtEvrakNo.Name = "txtEvrakNo";
            txtEvrakNo.Size = new Size(209, 33);
            txtEvrakNo.TabIndex = 4;
            // 
            // txtVeren
            // 
            txtVeren.Cursor = Cursors.IBeam;
            txtVeren.Font = new Font("Lucida Calligraphy", 14.25F);
            txtVeren.Location = new Point(193, 123);
            txtVeren.Name = "txtVeren";
            txtVeren.Size = new Size(209, 33);
            txtVeren.TabIndex = 3;
            // 
            // txtTutar
            // 
            txtTutar.Cursor = Cursors.IBeam;
            txtTutar.Font = new Font("Lucida Calligraphy", 14.25F);
            txtTutar.Location = new Point(193, 51);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(209, 33);
            txtTutar.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 14.25F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(12, 162);
            label5.Name = "label5";
            label5.Size = new Size(110, 24);
            label5.TabIndex = 37;
            label5.Text = "Evrak No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 14.25F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 38;
            label3.Text = "Tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 14.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 39;
            label4.Text = "Veren";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 14.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(12, 54);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 40;
            label6.Text = "Tutar";
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label2);
            pnlSil.Location = new Point(284, 198);
            pnlSil.Name = "pnlSil";
            pnlSil.Size = new Size(85, 65);
            pnlSil.TabIndex = 77;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(11, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 11.25F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 42);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 65;
            label2.Text = "Sil";
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BorderStyle = BorderStyle.FixedSingle;
            pnlGuncelle.Controls.Add(pictureBox2);
            pnlGuncelle.Controls.Add(label7);
            pnlGuncelle.Location = new Point(375, 198);
            pnlGuncelle.Name = "pnlGuncelle";
            pnlGuncelle.Size = new Size(85, 65);
            pnlGuncelle.TabIndex = 76;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(12, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Calligraphy", 11.25F);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(5, 42);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 64;
            label7.Text = "Güncelle";
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pictureBox4);
            pnlKaydet.Controls.Add(label10);
            pnlKaydet.Location = new Point(193, 198);
            pnlKaydet.Name = "pnlKaydet";
            pnlKaydet.Size = new Size(85, 65);
            pnlKaydet.TabIndex = 75;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(10, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Calligraphy", 11.25F);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(6, 41);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 66;
            label10.Text = "Kaydet";
            // 
            // FrmGelir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(mskTarih);
            Controls.Add(txtEvrakNo);
            Controls.Add(txtVeren);
            Controls.Add(txtTutar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(pcKapat);
            Controls.Add(dgvGelirler);
            Controls.Add(cmbGelirKategori);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGelir";
            Text = "GİDER İŞLEMLERİ";
            Load += FrmGelir_Load;
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGelirler).EndInit();
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

        private PictureBox pcKapat;
        private ComboBox cmbGelirKategori;
        private Label label1;
        private PictureBox pictureBox3;
        private MaskedTextBox mskTarih;
        private TextBox txtEvrakNo;
        private TextBox txtVeren;
        private TextBox txtTutar;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Panel pnlSil;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel pnlGuncelle;
        private PictureBox pictureBox2;
        private Label label7;
        private Panel pnlKaydet;
        private PictureBox pictureBox4;
        private Label label10;
        public DataGridView dgvGelirler;
    }
}