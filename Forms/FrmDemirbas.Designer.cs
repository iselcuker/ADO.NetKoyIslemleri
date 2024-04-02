namespace Forms
{
    partial class FrmDemirbas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemirbas));
            mskTarih = new MaskedTextBox();
            txtKimdenAlindi = new TextBox();
            txtFiyat = new TextBox();
            txtDemirbasAdi = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pcKapat = new PictureBox();
            dgvDemirbaslar = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            KoyId = new DataGridViewTextBoxColumn();
            DemirbasAdi = new DataGridViewTextBoxColumn();
            KimdenAlindi = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            FaturaTarihi = new DataGridViewTextBoxColumn();
            EvrakNo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtFaturaNo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pcKaydet = new PictureBox();
            pnlKaydet = new Panel();
            pnlGuncelle = new Panel();
            pnlSil = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDemirbaslar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcKaydet).BeginInit();
            pnlKaydet.SuspendLayout();
            pnlGuncelle.SuspendLayout();
            pnlSil.SuspendLayout();
            SuspendLayout();
            // 
            // mskTarih
            // 
            mskTarih.Cursor = Cursors.IBeam;
            mskTarih.Font = new Font("Lucida Calligraphy", 14.25F);
            mskTarih.Location = new Point(193, 119);
            mskTarih.Mask = "00/00/0000";
            mskTarih.Name = "mskTarih";
            mskTarih.Size = new Size(97, 33);
            mskTarih.TabIndex = 3;
            mskTarih.ValidatingType = typeof(DateTime);
            // 
            // txtKimdenAlindi
            // 
            txtKimdenAlindi.Cursor = Cursors.IBeam;
            txtKimdenAlindi.Font = new Font("Lucida Calligraphy", 14.25F);
            txtKimdenAlindi.Location = new Point(193, 47);
            txtKimdenAlindi.Name = "txtKimdenAlindi";
            txtKimdenAlindi.Size = new Size(209, 33);
            txtKimdenAlindi.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Cursor = Cursors.IBeam;
            txtFiyat.Font = new Font("Lucida Calligraphy", 14.25F);
            txtFiyat.Location = new Point(193, 83);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(209, 33);
            txtFiyat.TabIndex = 2;
            // 
            // txtDemirbasAdi
            // 
            txtDemirbasAdi.Cursor = Cursors.IBeam;
            txtDemirbasAdi.Font = new Font("Lucida Calligraphy", 14.25F);
            txtDemirbasAdi.Location = new Point(193, 11);
            txtDemirbasAdi.Name = "txtDemirbasAdi";
            txtDemirbasAdi.Size = new Size(209, 33);
            txtDemirbasAdi.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 14.25F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(12, 122);
            label5.Name = "label5";
            label5.Size = new Size(155, 24);
            label5.TabIndex = 56;
            label5.Text = "Fatura Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 14.25F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(12, 50);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 57;
            label3.Text = "Kimden Alındı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 14.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 58;
            label4.Text = "Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 14.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(12, 14);
            label6.Name = "label6";
            label6.Size = new Size(154, 24);
            label6.TabIndex = 59;
            label6.Text = "Demirbaş Adı";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(595, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(225, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 49;
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
            pcKapat.TabIndex = 48;
            pcKapat.TabStop = false;
            pcKapat.Click += pcKapat_Click;
            // 
            // dgvDemirbaslar
            // 
            dgvDemirbaslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDemirbaslar.BackgroundColor = SystemColors.Control;
            dgvDemirbaslar.BorderStyle = BorderStyle.Fixed3D;
            dgvDemirbaslar.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvDemirbaslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDemirbaslar.Columns.AddRange(new DataGridViewColumn[] { Id, KoyId, DemirbasAdi, KimdenAlindi, Tutar, FaturaTarihi, EvrakNo });
            dgvDemirbaslar.Dock = DockStyle.Bottom;
            dgvDemirbaslar.Location = new Point(0, 273);
            dgvDemirbaslar.Name = "dgvDemirbaslar";
            dgvDemirbaslar.Size = new Size(875, 358);
            dgvDemirbaslar.TabIndex = 47;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // KoyId
            // 
            KoyId.HeaderText = "Köyü";
            KoyId.Name = "KoyId";
            // 
            // DemirbasAdi
            // 
            DemirbasAdi.HeaderText = "Demirbaş Adı";
            DemirbasAdi.Name = "DemirbasAdi";
            // 
            // KimdenAlindi
            // 
            KimdenAlindi.HeaderText = "Kimden Alındı";
            KimdenAlindi.Name = "KimdenAlindi";
            // 
            // Tutar
            // 
            Tutar.HeaderText = "Fiyatı";
            Tutar.Name = "Tutar";
            // 
            // FaturaTarihi
            // 
            FaturaTarihi.HeaderText = "Fatura Tarihi";
            FaturaTarihi.Name = "FaturaTarihi";
            // 
            // EvrakNo
            // 
            EvrakNo.HeaderText = "Evrak No";
            EvrakNo.Name = "EvrakNo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 14.25F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 161);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 58;
            label1.Text = "Fatura No";
            // 
            // txtFaturaNo
            // 
            txtFaturaNo.Cursor = Cursors.IBeam;
            txtFaturaNo.Font = new Font("Lucida Calligraphy", 14.25F);
            txtFaturaNo.Location = new Point(193, 158);
            txtFaturaNo.Name = "txtFaturaNo";
            txtFaturaNo.Size = new Size(209, 33);
            txtFaturaNo.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Calligraphy", 11.25F);
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(5, 42);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 64;
            label9.Text = "Güncelle";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 11.25F);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(26, 42);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 65;
            label8.Text = "Sil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Calligraphy", 11.25F);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(6, 41);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 66;
            label7.Text = "Kaydet";
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
            // pcKaydet
            // 
            pcKaydet.Cursor = Cursors.Hand;
            pcKaydet.Image = (Image)resources.GetObject("pcKaydet.Image");
            pcKaydet.ImeMode = ImeMode.NoControl;
            pcKaydet.Location = new Point(10, 1);
            pcKaydet.Name = "pcKaydet";
            pcKaydet.Size = new Size(62, 42);
            pcKaydet.SizeMode = PictureBoxSizeMode.StretchImage;
            pcKaydet.TabIndex = 69;
            pcKaydet.TabStop = false;
            // 
            // pnlKaydet
            // 
            pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            pnlKaydet.Controls.Add(pcKaydet);
            pnlKaydet.Controls.Add(label7);
            pnlKaydet.Location = new Point(193, 198);
            pnlKaydet.Name = "pnlKaydet";
            pnlKaydet.Size = new Size(85, 65);
            pnlKaydet.TabIndex = 70;
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BorderStyle = BorderStyle.FixedSingle;
            pnlGuncelle.Controls.Add(pictureBox2);
            pnlGuncelle.Controls.Add(label9);
            pnlGuncelle.Location = new Point(375, 198);
            pnlGuncelle.Name = "pnlGuncelle";
            pnlGuncelle.Size = new Size(85, 65);
            pnlGuncelle.TabIndex = 71;
            // 
            // pnlSil
            // 
            pnlSil.BorderStyle = BorderStyle.FixedSingle;
            pnlSil.Controls.Add(pictureBox1);
            pnlSil.Controls.Add(label8);
            pnlSil.Location = new Point(284, 198);
            pnlSil.Name = "pnlSil";
            pnlSil.Size = new Size(85, 65);
            pnlSil.TabIndex = 71;
            // 
            // FrmDemirbas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(pnlSil);
            Controls.Add(pnlGuncelle);
            Controls.Add(pnlKaydet);
            Controls.Add(mskTarih);
            Controls.Add(txtKimdenAlindi);
            Controls.Add(txtFaturaNo);
            Controls.Add(txtFiyat);
            Controls.Add(txtDemirbasAdi);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(pcKapat);
            Controls.Add(dgvDemirbaslar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDemirbas";
            Text = "FrmDemirbas";
            Load += FrmDemirbas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcKapat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDemirbaslar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcKaydet).EndInit();
            pnlKaydet.ResumeLayout(false);
            pnlKaydet.PerformLayout();
            pnlGuncelle.ResumeLayout(false);
            pnlGuncelle.PerformLayout();
            pnlSil.ResumeLayout(false);
            pnlSil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskTarih;
        private TextBox txtKimdenAlindi;
        private TextBox txtFiyat;
        private TextBox txtDemirbasAdi;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pcKapat;
        private Label label1;
        private TextBox txtFaturaNo;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pcKaydet;
        public DataGridView dgvDemirbaslar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn KoyId;
        private DataGridViewTextBoxColumn DemirbasAdi;
        private DataGridViewTextBoxColumn KimdenAlindi;
        private DataGridViewTextBoxColumn Tutar;
        private DataGridViewTextBoxColumn FaturaTarihi;
        private DataGridViewTextBoxColumn EvrakNo;
        private Panel pnlKaydet;
        private Panel pnlGuncelle;
        private Panel pnlSil;
    }
}