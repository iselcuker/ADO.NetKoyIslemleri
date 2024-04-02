namespace Forms
{
    partial class FrmEkGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEkGider));
            pictureBox3 = new PictureBox();
            pcKapat = new PictureBox();
            dgvEkGiderler = new DataGridView();
            txtTutar = new TextBox();
            label2 = new Label();
            cmbDegisiklik = new ComboBox();
            label3 = new Label();
            cmbGiderAltKategori = new ComboBox();
            label6 = new Label();
            cmbGiderKategori = new ComboBox();
            label1 = new Label();
            pnlSil = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pnlGuncelle = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pnlKaydet = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEkGiderler).BeginInit();
            pnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(619, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 269);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 53;
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
            pcKapat.TabIndex = 49;
            pcKapat.TabStop = false;
            pcKapat.Click += pcKapat_Click;
            // 
            // dgvEkGiderler
            // 
            dgvEkGiderler.BackgroundColor = SystemColors.Control;
            dgvEkGiderler.BorderStyle = BorderStyle.Fixed3D;
            dgvEkGiderler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvEkGiderler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEkGiderler.Dock = DockStyle.Bottom;
            dgvEkGiderler.Location = new Point(0, 301);
            dgvEkGiderler.Name = "dgvEkGiderler";
            dgvEkGiderler.Size = new Size(875, 330);
            dgvEkGiderler.TabIndex = 48;
            // 
            // txtTutar
            // 
            txtTutar.Cursor = Cursors.IBeam;
            txtTutar.Font = new Font("Lucida Calligraphy", 14.25F);
            txtTutar.Location = new Point(217, 123);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(209, 33);
            txtTutar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 14.25F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 40;
            label2.Text = "Tutar";
            // 
            // cmbDegisiklik
            // 
            cmbDegisiklik.BackColor = SystemColors.Control;
            cmbDegisiklik.Cursor = Cursors.Hand;
            cmbDegisiklik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegisiklik.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbDegisiklik.FormattingEnabled = true;
            cmbDegisiklik.Location = new Point(217, 85);
            cmbDegisiklik.Name = "cmbDegisiklik";
            cmbDegisiklik.Size = new Size(396, 32);
            cmbDegisiklik.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 14.25F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 42;
            label3.Text = "Değişiklik";
            // 
            // cmbGiderAltKategori
            // 
            cmbGiderAltKategori.BackColor = SystemColors.Control;
            cmbGiderAltKategori.Cursor = Cursors.Hand;
            cmbGiderAltKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGiderAltKategori.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbGiderAltKategori.FormattingEnabled = true;
            cmbGiderAltKategori.Location = new Point(217, 49);
            cmbGiderAltKategori.Name = "cmbGiderAltKategori";
            cmbGiderAltKategori.Size = new Size(396, 32);
            cmbGiderAltKategori.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 14.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(12, 58);
            label6.Name = "label6";
            label6.Size = new Size(203, 24);
            label6.TabIndex = 41;
            label6.Text = "Gider Alt Kategori";
            // 
            // cmbGiderKategori
            // 
            cmbGiderKategori.BackColor = SystemColors.Control;
            cmbGiderKategori.Cursor = Cursors.Hand;
            cmbGiderKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGiderKategori.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbGiderKategori.FormattingEnabled = true;
            cmbGiderKategori.Location = new Point(217, 14);
            cmbGiderKategori.Name = "cmbGiderKategori";
            cmbGiderKategori.Size = new Size(396, 32);
            cmbGiderKategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 14.25F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 43;
            label1.Text = "Gider Kategori";
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label4);
            pnlSil.Location = new Point(308, 162);
            pnlSil.Name = "pnlSil";
            pnlSil.Size = new Size(85, 65);
            pnlSil.TabIndex = 74;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 11.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(26, 42);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 65;
            label4.Text = "Sil";
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BorderStyle = BorderStyle.FixedSingle;
            pnlGuncelle.Controls.Add(pictureBox2);
            pnlGuncelle.Controls.Add(label5);
            pnlGuncelle.Location = new Point(399, 162);
            pnlGuncelle.Name = "pnlGuncelle";
            pnlGuncelle.Size = new Size(85, 65);
            pnlGuncelle.TabIndex = 73;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 11.25F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(5, 42);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 64;
            label5.Text = "Güncelle";
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pictureBox4);
            pnlKaydet.Controls.Add(label10);
            pnlKaydet.Location = new Point(217, 162);
            pnlKaydet.Name = "pnlKaydet";
            pnlKaydet.Size = new Size(85, 65);
            pnlKaydet.TabIndex = 72;
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
            // FrmEkGider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(pictureBox3);
            Controls.Add(pcKapat);
            Controls.Add(dgvEkGiderler);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(cmbDegisiklik);
            Controls.Add(label3);
            Controls.Add(cmbGiderAltKategori);
            Controls.Add(label6);
            Controls.Add(cmbGiderKategori);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEkGider";
            Text = "FrmEkGider";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEkGiderler).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pcKapat;
        private DataGridView dgvEkGiderler;
        private TextBox txtTutar;
        private Label label2;
        private ComboBox cmbDegisiklik;
        private Label label3;
        private ComboBox cmbGiderAltKategori;
        private Label label6;
        private ComboBox cmbGiderKategori;
        private Label label1;
        private Panel pnlSil;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel pnlGuncelle;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel pnlKaydet;
        private PictureBox pictureBox4;
        private Label label10;
    }
}