namespace Forms
{
    partial class FrmEkButce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEkButce));
            pctEkGelir = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pctEkGider = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            dgvEkGelirler = new DataGridView();
            txtEkButceTutari = new TextBox();
            label4 = new Label();
            pcKapat = new PictureBox();
            pnlSil = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlGuncelle = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pnlKaydet = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctEkGelir).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctEkGider).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEkGelirler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            pnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pctEkGelir
            // 
            pctEkGelir.Cursor = Cursors.Hand;
            pctEkGelir.Dock = DockStyle.Top;
            pctEkGelir.Image = Properties.Resources.Gelir;
            pctEkGelir.Location = new Point(0, 0);
            pctEkGelir.Name = "pctEkGelir";
            pctEkGelir.Size = new Size(120, 50);
            pctEkGelir.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEkGelir.TabIndex = 6;
            pctEkGelir.TabStop = false;
            pctEkGelir.Click += pctEkGelir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 18;
            label1.Text = "Ek Gelir";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pctEkGelir);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(558, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 80);
            panel2.TabIndex = 39;
            // 
            // pctEkGider
            // 
            pctEkGider.Cursor = Cursors.Hand;
            pctEkGider.Dock = DockStyle.Top;
            pctEkGider.Image = (Image)resources.GetObject("pctEkGider.Image");
            pctEkGider.Location = new Point(0, 0);
            pctEkGider.Name = "pctEkGider";
            pctEkGider.Size = new Size(120, 50);
            pctEkGider.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEkGider.TabIndex = 6;
            pctEkGider.TabStop = false;
            pctEkGider.Click += pctEkGider_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(21, 52);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 18;
            label5.Text = "Ek Gider";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pctEkGider);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(684, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 80);
            panel3.TabIndex = 38;
            // 
            // dgvEkGelirler
            // 
            dgvEkGelirler.BackgroundColor = SystemColors.Control;
            dgvEkGelirler.BorderStyle = BorderStyle.Fixed3D;
            dgvEkGelirler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvEkGelirler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEkGelirler.Dock = DockStyle.Bottom;
            dgvEkGelirler.Location = new Point(0, 140);
            dgvEkGelirler.Name = "dgvEkGelirler";
            dgvEkGelirler.Size = new Size(875, 491);
            dgvEkGelirler.TabIndex = 36;
            // 
            // txtEkButceTutari
            // 
            txtEkButceTutari.Cursor = Cursors.IBeam;
            txtEkButceTutari.Font = new Font("Lucida Calligraphy", 14.25F);
            txtEkButceTutari.Location = new Point(158, 19);
            txtEkButceTutari.Name = "txtEkButceTutari";
            txtEkButceTutari.Size = new Size(209, 33);
            txtEkButceTutari.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 14.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 28;
            label4.Text = "Bütçe Tutarı";
            // 
            // pcKapat
            // 
            pcKapat.Image = Properties.Resources.power;
            pcKapat.ImeMode = ImeMode.NoControl;
            pcKapat.Location = new Point(835, 0);
            pcKapat.Name = "pcKapat";
            pcKapat.Size = new Size(40, 35);
            pcKapat.SizeMode = PictureBoxSizeMode.StretchImage;
            pcKapat.TabIndex = 27;
            pcKapat.TabStop = false;
            pcKapat.Click += pcKapat_Click;
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label2);
            pnlSil.Location = new Point(249, 58);
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
            pnlGuncelle.Controls.Add(label3);
            pnlGuncelle.Location = new Point(340, 58);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 11.25F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(5, 42);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 64;
            label3.Text = "Güncelle";
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pictureBox3);
            pnlKaydet.Controls.Add(label6);
            pnlKaydet.Location = new Point(158, 58);
            pnlKaydet.Name = "pnlKaydet";
            pnlKaydet.Size = new Size(85, 65);
            pnlKaydet.TabIndex = 72;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(10, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 69;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 11.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(6, 41);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 66;
            label6.Text = "Kaydet";
            // 
            // FrmEkButce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dgvEkGelirler);
            Controls.Add(txtEkButceTutari);
            Controls.Add(label4);
            Controls.Add(pcKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEkButce";
            Text = "FrmEkButce";
            ((System.ComponentModel.ISupportInitialize)pctEkGelir).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctEkGider).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEkGelirler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            pnlSil.ResumeLayout(false);
            pnlSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlGuncelle.ResumeLayout(false);
            pnlGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlKaydet.ResumeLayout(false);
            pnlKaydet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox pctEkGelir;
        private Label label1;
        private Panel panel2;
        private PictureBox pctEkGider;
        private Label label5;
        private Panel panel3;
        private DataGridView dgvEkGelirler;
        private TextBox txtEkButceTutari;
        private Label label4;
        private PictureBox pcKapat;
        private Panel pnlSil;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel pnlGuncelle;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel pnlKaydet;
        private PictureBox pictureBox3;
        private Label label6;
    }
}