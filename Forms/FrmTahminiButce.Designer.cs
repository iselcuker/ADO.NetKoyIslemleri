namespace Forms
{
    partial class FrmTahminiButce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTahminiButce));
            pcKapat = new PictureBox();
            txtButceTutari = new TextBox();
            label4 = new Label();
            dgvTahminiButceler = new DataGridView();
            panel3 = new Panel();
            pctTahminiGider = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            pctTahminiGelir = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pctTahiminIdariIsler = new PictureBox();
            pnlSil = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pnlGuncelle = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pnlKaydet = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTahminiButceler).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahminiGider).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahminiGelir).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahiminIdariIsler).BeginInit();
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
            pcKapat.TabIndex = 15;
            pcKapat.TabStop = false;
            pcKapat.Click += pcKapat_Click;
            // 
            // txtButceTutari
            // 
            txtButceTutari.Font = new Font("Lucida Calligraphy", 14.25F);
            txtButceTutari.Location = new Point(158, 19);
            txtButceTutari.Name = "txtButceTutari";
            txtButceTutari.Size = new Size(209, 33);
            txtButceTutari.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 14.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 16;
            label4.Text = "Bütçe Tutarı";
            // 
            // dgvTahminiButceler
            // 
            dgvTahminiButceler.BackgroundColor = SystemColors.Control;
            dgvTahminiButceler.BorderStyle = BorderStyle.Fixed3D;
            dgvTahminiButceler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvTahminiButceler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTahminiButceler.Dock = DockStyle.Bottom;
            dgvTahminiButceler.Location = new Point(0, 140);
            dgvTahminiButceler.Name = "dgvTahminiButceler";
            dgvTahminiButceler.Size = new Size(875, 491);
            dgvTahminiButceler.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(pctTahminiGider);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(563, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 80);
            panel3.TabIndex = 25;
            // 
            // pctTahminiGider
            // 
            pctTahminiGider.Cursor = Cursors.Hand;
            pctTahminiGider.Dock = DockStyle.Top;
            pctTahminiGider.Image = (Image)resources.GetObject("pctTahminiGider.Image");
            pctTahminiGider.Location = new Point(0, 0);
            pctTahminiGider.Name = "pctTahminiGider";
            pctTahminiGider.Size = new Size(120, 50);
            pctTahminiGider.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTahminiGider.TabIndex = 6;
            pctTahminiGider.TabStop = false;
            pctTahminiGider.Click += pctTahminiGider_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(-5, 52);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 18;
            label5.Text = "Tahmini Gider";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pctTahminiGelir);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(437, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 80);
            panel2.TabIndex = 26;
            // 
            // pctTahminiGelir
            // 
            pctTahminiGelir.Cursor = Cursors.Hand;
            pctTahminiGelir.Dock = DockStyle.Top;
            pctTahminiGelir.Image = Properties.Resources.Gelir;
            pctTahminiGelir.Location = new Point(0, 0);
            pctTahminiGelir.Name = "pctTahminiGelir";
            pctTahminiGelir.Size = new Size(120, 50);
            pctTahminiGelir.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTahminiGelir.TabIndex = 6;
            pctTahminiGelir.TabStop = false;
            pctTahminiGelir.Click += pctTahminiGelir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(-4, 52);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 18;
            label1.Text = "Tahmini Gelir";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pctTahiminIdariIsler);
            panel1.Location = new Point(690, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 80);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(-5, 52);
            label2.Name = "label2";
            label2.Size = new Size(129, 16);
            label2.TabIndex = 18;
            label2.Text = "Tahmini İdari İşler";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctTahiminIdariIsler
            // 
            pctTahiminIdariIsler.Cursor = Cursors.Hand;
            pctTahiminIdariIsler.Dock = DockStyle.Top;
            pctTahiminIdariIsler.Image = (Image)resources.GetObject("pctTahiminIdariIsler.Image");
            pctTahiminIdariIsler.Location = new Point(0, 0);
            pctTahiminIdariIsler.Name = "pctTahiminIdariIsler";
            pctTahiminIdariIsler.Size = new Size(120, 50);
            pctTahiminIdariIsler.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTahiminIdariIsler.TabIndex = 6;
            pctTahiminIdariIsler.TabStop = false;
            pctTahiminIdariIsler.Click += pctTahiminIdariIsler_Click;
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label3);
            pnlSil.Location = new Point(249, 58);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 11.25F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(26, 42);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 65;
            label3.Text = "Sil";
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BorderStyle = BorderStyle.FixedSingle;
            pnlGuncelle.Controls.Add(pictureBox2);
            pnlGuncelle.Controls.Add(label6);
            pnlGuncelle.Location = new Point(340, 58);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 11.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(5, 42);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 64;
            label6.Text = "Güncelle";
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pictureBox4);
            pnlKaydet.Controls.Add(label10);
            pnlKaydet.Location = new Point(158, 58);
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
            // FrmTahminiButce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvTahminiButceler);
            Controls.Add(txtButceTutari);
            Controls.Add(label4);
            Controls.Add(pcKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTahminiButce";
            Text = "FrmTahminiButce";
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTahminiButceler).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahminiGider).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahminiGelir).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahiminIdariIsler).EndInit();
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
        private TextBox txtButceTutari;
        private Label label4;
        private DataGridView dgvTahminiButceler;
        private Panel panel3;
        private PictureBox pctTahminiGider;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pctTahiminIdariIsler;
        public PictureBox pctTahminiGelir;
        private Panel pnlSil;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel pnlGuncelle;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel pnlKaydet;
        private PictureBox pictureBox4;
        private Label label10;
    }
}