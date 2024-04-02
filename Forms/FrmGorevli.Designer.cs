namespace Forms
{
    partial class FrmGorevli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGorevli));
            mskTelefoNo = new MaskedTextBox();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pcKapat = new PictureBox();
            dgvGorevliler = new DataGridView();
            cmbGelirKategori = new ComboBox();
            pnlSil = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlGuncelle = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pnlKaydet = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGorevliler).BeginInit();
            pnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // mskTelefoNo
            // 
            mskTelefoNo.Cursor = Cursors.IBeam;
            mskTelefoNo.Font = new Font("Lucida Calligraphy", 14.25F);
            mskTelefoNo.Location = new Point(193, 119);
            mskTelefoNo.Mask = "(999) 000-0000";
            mskTelefoNo.Name = "mskTelefoNo";
            mskTelefoNo.Size = new Size(137, 33);
            mskTelefoNo.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Cursor = Cursors.IBeam;
            txtSoyadi.Font = new Font("Lucida Calligraphy", 14.25F);
            txtSoyadi.Location = new Point(193, 47);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(209, 33);
            txtSoyadi.TabIndex = 1;
            // 
            // txtAdi
            // 
            txtAdi.Cursor = Cursors.IBeam;
            txtAdi.Font = new Font("Lucida Calligraphy", 14.25F);
            txtAdi.Location = new Point(193, 11);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(209, 33);
            txtAdi.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 14.25F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(12, 122);
            label5.Name = "label5";
            label5.Size = new Size(120, 24);
            label5.TabIndex = 73;
            label5.Text = "Telefon No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 14.25F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(12, 50);
            label3.Name = "label3";
            label3.Size = new Size(78, 24);
            label3.TabIndex = 74;
            label3.Text = "Soyadı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 14.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 75;
            label4.Text = "Ünvanı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 14.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(12, 14);
            label6.Name = "label6";
            label6.Size = new Size(49, 24);
            label6.TabIndex = 77;
            label6.Text = "Adı";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(594, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(226, 209);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 72;
            pictureBox3.TabStop = false;
            // 
            // pcKapat
            // 
            pcKapat.Image = Properties.Resources.power;
            pcKapat.ImeMode = ImeMode.NoControl;
            pcKapat.Location = new Point(835, 0);
            pcKapat.Name = "pcKapat";
            pcKapat.Size = new Size(40, 35);
            pcKapat.SizeMode = PictureBoxSizeMode.StretchImage;
            pcKapat.TabIndex = 71;
            pcKapat.TabStop = false;
            pcKapat.Click += pcKapat_Click;
            // 
            // dgvGorevliler
            // 
            dgvGorevliler.BackgroundColor = SystemColors.Control;
            dgvGorevliler.BorderStyle = BorderStyle.Fixed3D;
            dgvGorevliler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGorevliler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGorevliler.Dock = DockStyle.Bottom;
            dgvGorevliler.Location = new Point(0, 246);
            dgvGorevliler.Name = "dgvGorevliler";
            dgvGorevliler.Size = new Size(875, 385);
            dgvGorevliler.TabIndex = 70;
            // 
            // cmbGelirKategori
            // 
            cmbGelirKategori.BackColor = SystemColors.Control;
            cmbGelirKategori.Cursor = Cursors.Hand;
            cmbGelirKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGelirKategori.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbGelirKategori.ForeColor = SystemColors.MenuText;
            cmbGelirKategori.FormattingEnabled = true;
            cmbGelirKategori.Items.AddRange(new object[] { "İsmail", "Selçuker" });
            cmbGelirKategori.Location = new Point(193, 83);
            cmbGelirKategori.Name = "cmbGelirKategori";
            cmbGelirKategori.Size = new Size(216, 32);
            cmbGelirKategori.TabIndex = 2;
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label1);
            pnlSil.Location = new Point(284, 158);
            pnlSil.Name = "pnlSil";
            pnlSil.Size = new Size(85, 65);
            pnlSil.TabIndex = 80;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 11.25F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 65;
            label1.Text = "Sil";
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BorderStyle = BorderStyle.FixedSingle;
            pnlGuncelle.Controls.Add(pictureBox2);
            pnlGuncelle.Controls.Add(label2);
            pnlGuncelle.Location = new Point(375, 158);
            pnlGuncelle.Name = "pnlGuncelle";
            pnlGuncelle.Size = new Size(85, 65);
            pnlGuncelle.TabIndex = 79;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 11.25F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(5, 42);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 64;
            label2.Text = "Güncelle";
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pictureBox4);
            pnlKaydet.Controls.Add(label10);
            pnlKaydet.Location = new Point(193, 158);
            pnlKaydet.Name = "pnlKaydet";
            pnlKaydet.Size = new Size(85, 65);
            pnlKaydet.TabIndex = 78;
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
            // FrmGorevli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(cmbGelirKategori);
            Controls.Add(mskTelefoNo);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(pcKapat);
            Controls.Add(dgvGorevliler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGorevli";
            Text = "FrmGorevli";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGorevliler).EndInit();
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
        private MaskedTextBox mskTelefoNo;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pcKapat;
        private DataGridView dgvGorevliler;
        private ComboBox cmbGelirKategori;
        private Panel pnlSil;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnlGuncelle;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel pnlKaydet;
        private PictureBox pictureBox4;
        private Label label10;
    }
}