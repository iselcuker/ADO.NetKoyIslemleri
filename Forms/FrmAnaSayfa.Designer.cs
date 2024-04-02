namespace Forms
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            lblBaslik = new Label();
            label1 = new Label();
            cmbIlce = new ComboBox();
            lblKoy = new Label();
            cmbKoy = new ComboBox();
            lblDonem = new Label();
            cmbDonem = new ComboBox();
            grbNot = new GroupBox();
            rctxtNot = new RichTextBox();
            panel8 = new Panel();
            pctNotButon = new PictureBox();
            label10 = new Label();
            grpSonDurum = new GroupBox();
            lblSonuc = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblToplamGelir = new Label();
            lblToplamGider = new Label();
            pnlEkran = new Panel();
            pnlBaslik = new Panel();
            pnlGelir = new Panel();
            pctGelirBtn = new PictureBox();
            label4 = new Label();
            pnlButonlar = new Panel();
            pnlDemirbas = new Panel();
            pctDemirbas = new PictureBox();
            label8 = new Label();
            pnlEkButce = new Panel();
            pctEkButce = new PictureBox();
            label11 = new Label();
            pnlTahminiButce = new Panel();
            label7 = new Label();
            pctTahminiButceBtn = new PictureBox();
            pnlNot = new Panel();
            pctNotBtn = new PictureBox();
            label6 = new Label();
            pnlGorevli = new Panel();
            pctGorevli = new PictureBox();
            label9 = new Label();
            pnlGider = new Panel();
            pctGiderBtn = new PictureBox();
            label5 = new Label();
            grbNot.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctNotButon).BeginInit();
            grpSonDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBaslik.SuspendLayout();
            pnlGelir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctGelirBtn).BeginInit();
            pnlButonlar.SuspendLayout();
            pnlDemirbas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDemirbas).BeginInit();
            pnlEkButce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctEkButce).BeginInit();
            pnlTahminiButce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahminiButceBtn).BeginInit();
            pnlNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctNotBtn).BeginInit();
            pnlGorevli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctGorevli).BeginInit();
            pnlGider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctGiderBtn).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Dock = DockStyle.Fill;
            lblBaslik.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBaslik.ForeColor = Color.Teal;
            lblBaslik.Location = new Point(0, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(0, 42);
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 14.25F);
            label1.Location = new Point(8, 82);
            label1.Name = "label1";
            label1.Size = new Size(54, 24);
            label1.TabIndex = 1;
            label1.Text = "İLÇE";
            // 
            // cmbIlce
            // 
            cmbIlce.Cursor = Cursors.Hand;
            cmbIlce.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIlce.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(111, 79);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(215, 32);
            cmbIlce.TabIndex = 0;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // lblKoy
            // 
            lblKoy.AutoSize = true;
            lblKoy.Font = new Font("Lucida Calligraphy", 14.25F);
            lblKoy.Location = new Point(8, 120);
            lblKoy.Name = "lblKoy";
            lblKoy.Size = new Size(60, 24);
            lblKoy.TabIndex = 1;
            lblKoy.Text = "KÖY";
            // 
            // cmbKoy
            // 
            cmbKoy.Cursor = Cursors.Hand;
            cmbKoy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKoy.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(111, 117);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(215, 32);
            cmbKoy.TabIndex = 1;
            cmbKoy.SelectedIndexChanged += cmbKoy_SelectedIndexChanged;
            // 
            // lblDonem
            // 
            lblDonem.AutoSize = true;
            lblDonem.Font = new Font("Lucida Calligraphy", 14.25F);
            lblDonem.Location = new Point(8, 158);
            lblDonem.Name = "lblDonem";
            lblDonem.Size = new Size(99, 24);
            lblDonem.TabIndex = 1;
            lblDonem.Text = "DÖNEM";
            // 
            // cmbDonem
            // 
            cmbDonem.Cursor = Cursors.Hand;
            cmbDonem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonem.Font = new Font("Lucida Calligraphy", 14.25F);
            cmbDonem.FormattingEnabled = true;
            cmbDonem.Location = new Point(111, 155);
            cmbDonem.Name = "cmbDonem";
            cmbDonem.Size = new Size(92, 32);
            cmbDonem.TabIndex = 2;
            cmbDonem.SelectedIndexChanged += cmbDonem_SelectedIndexChanged;
            // 
            // grbNot
            // 
            grbNot.Controls.Add(rctxtNot);
            grbNot.Controls.Add(panel8);
            grbNot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grbNot.ForeColor = SystemColors.ActiveCaptionText;
            grbNot.Location = new Point(12, 216);
            grbNot.Name = "grbNot";
            grbNot.Size = new Size(314, 263);
            grbNot.TabIndex = 4;
            grbNot.TabStop = false;
            grbNot.Text = "NOT";
            // 
            // rctxtNot
            // 
            rctxtNot.Location = new Point(6, 22);
            rctxtNot.Name = "rctxtNot";
            rctxtNot.Size = new Size(300, 156);
            rctxtNot.TabIndex = 0;
            rctxtNot.Text = "";
            // 
            // panel8
            // 
            panel8.Controls.Add(pctNotButon);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(213, 179);
            panel8.Name = "panel8";
            panel8.Size = new Size(90, 80);
            panel8.TabIndex = 19;
            // 
            // pctNotButon
            // 
            pctNotButon.Cursor = Cursors.Hand;
            pctNotButon.Dock = DockStyle.Top;
            pctNotButon.Image = (Image)resources.GetObject("pctNotButon.Image");
            pctNotButon.Location = new Point(0, 0);
            pctNotButon.Name = "pctNotButon";
            pctNotButon.Size = new Size(90, 50);
            pctNotButon.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNotButon.TabIndex = 6;
            pctNotButon.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Calligraphy", 14.25F);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(20, 52);
            label10.Name = "label10";
            label10.Size = new Size(50, 24);
            label10.TabIndex = 18;
            label10.Text = "Not";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpSonDurum
            // 
            grpSonDurum.Controls.Add(lblSonuc);
            grpSonDurum.Controls.Add(pictureBox3);
            grpSonDurum.Controls.Add(pictureBox2);
            grpSonDurum.Controls.Add(panel1);
            grpSonDurum.Controls.Add(pictureBox1);
            grpSonDurum.Controls.Add(lblToplamGelir);
            grpSonDurum.Controls.Add(lblToplamGider);
            grpSonDurum.Location = new Point(17, 544);
            grpSonDurum.Name = "grpSonDurum";
            grpSonDurum.Size = new Size(309, 217);
            grpSonDurum.TabIndex = 5;
            grpSonDurum.TabStop = false;
            grpSonDurum.Text = "SON DURUM";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(96, 155);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(33, 29);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "00";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 143);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(6, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 3);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gelir;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamGelir.Location = new Point(96, 33);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(33, 29);
            lblToplamGelir.TabIndex = 0;
            lblToplamGelir.Text = "00";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamGider.Location = new Point(96, 88);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(33, 29);
            lblToplamGider.TabIndex = 0;
            lblToplamGider.Text = "00";
            // 
            // pnlEkran
            // 
            pnlEkran.BackColor = SystemColors.Control;
            pnlEkran.BorderStyle = BorderStyle.FixedSingle;
            pnlEkran.Location = new Point(340, 155);
            pnlEkran.Name = "pnlEkran";
            pnlEkran.Size = new Size(875, 631);
            pnlEkran.TabIndex = 1;
            // 
            // pnlBaslik
            // 
            pnlBaslik.Controls.Add(lblBaslik);
            pnlBaslik.Dock = DockStyle.Top;
            pnlBaslik.Location = new Point(0, 0);
            pnlBaslik.Name = "pnlBaslik";
            pnlBaslik.Size = new Size(1215, 47);
            pnlBaslik.TabIndex = 0;
            // 
            // pnlGelir
            // 
            pnlGelir.BorderStyle = BorderStyle.FixedSingle;
            pnlGelir.Controls.Add(pctGelirBtn);
            pnlGelir.Controls.Add(label4);
            pnlGelir.Location = new Point(2, 6);
            pnlGelir.Name = "pnlGelir";
            pnlGelir.Size = new Size(120, 80);
            pnlGelir.TabIndex = 19;
            pnlGelir.Paint += pnlGelir_Paint;
            // 
            // pctGelirBtn
            // 
            pctGelirBtn.Cursor = Cursors.Hand;
            pctGelirBtn.Dock = DockStyle.Top;
            pctGelirBtn.Image = Properties.Resources.Gelir;
            pctGelirBtn.Location = new Point(0, 0);
            pctGelirBtn.Name = "pctGelirBtn";
            pctGelirBtn.Size = new Size(118, 50);
            pctGelirBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pctGelirBtn.TabIndex = 6;
            pctGelirBtn.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 14.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(27, 52);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 18;
            label4.Text = "Gelir";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlButonlar
            // 
            pnlButonlar.BackColor = SystemColors.Control;
            pnlButonlar.Controls.Add(pnlDemirbas);
            pnlButonlar.Controls.Add(pnlEkButce);
            pnlButonlar.Controls.Add(pnlTahminiButce);
            pnlButonlar.Controls.Add(pnlNot);
            pnlButonlar.Controls.Add(pnlGorevli);
            pnlButonlar.Controls.Add(pnlGider);
            pnlButonlar.Controls.Add(pnlGelir);
            pnlButonlar.Location = new Point(340, 59);
            pnlButonlar.Name = "pnlButonlar";
            pnlButonlar.Size = new Size(875, 90);
            pnlButonlar.TabIndex = 3;
            // 
            // pnlDemirbas
            // 
            pnlDemirbas.BorderStyle = BorderStyle.FixedSingle;
            pnlDemirbas.Controls.Add(pctDemirbas);
            pnlDemirbas.Controls.Add(label8);
            pnlDemirbas.Location = new Point(494, 6);
            pnlDemirbas.Name = "pnlDemirbas";
            pnlDemirbas.Size = new Size(120, 80);
            pnlDemirbas.TabIndex = 19;
            // 
            // pctDemirbas
            // 
            pctDemirbas.Cursor = Cursors.Hand;
            pctDemirbas.Dock = DockStyle.Top;
            pctDemirbas.Image = (Image)resources.GetObject("pctDemirbas.Image");
            pctDemirbas.Location = new Point(0, 0);
            pctDemirbas.Name = "pctDemirbas";
            pctDemirbas.Size = new Size(118, 50);
            pctDemirbas.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDemirbas.TabIndex = 6;
            pctDemirbas.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(14, 52);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 18;
            label8.Text = "Demirbaş";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlEkButce
            // 
            pnlEkButce.BorderStyle = BorderStyle.FixedSingle;
            pnlEkButce.Controls.Add(pctEkButce);
            pnlEkButce.Controls.Add(label11);
            pnlEkButce.Location = new Point(740, 6);
            pnlEkButce.Name = "pnlEkButce";
            pnlEkButce.Size = new Size(120, 80);
            pnlEkButce.TabIndex = 19;
            // 
            // pctEkButce
            // 
            pctEkButce.Cursor = Cursors.Hand;
            pctEkButce.Image = Properties.Resources.Bütçe;
            pctEkButce.Location = new Point(3, 3);
            pctEkButce.Name = "pctEkButce";
            pctEkButce.Size = new Size(114, 50);
            pctEkButce.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEkButce.TabIndex = 0;
            pctEkButce.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(25, 54);
            label11.Name = "label11";
            label11.Size = new Size(69, 17);
            label11.TabIndex = 18;
            label11.Text = "Ek Bütçe";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTahminiButce
            // 
            pnlTahminiButce.BorderStyle = BorderStyle.FixedSingle;
            pnlTahminiButce.Controls.Add(label7);
            pnlTahminiButce.Controls.Add(pctTahminiButceBtn);
            pnlTahminiButce.Location = new Point(371, 6);
            pnlTahminiButce.Name = "pnlTahminiButce";
            pnlTahminiButce.Size = new Size(120, 80);
            pnlTahminiButce.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Calligraphy", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(5, 53);
            label7.Name = "label7";
            label7.Size = new Size(110, 17);
            label7.TabIndex = 18;
            label7.Text = "Tahmini Bütçe";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctTahminiButceBtn
            // 
            pctTahminiButceBtn.Cursor = Cursors.Hand;
            pctTahminiButceBtn.Dock = DockStyle.Top;
            pctTahminiButceBtn.Image = (Image)resources.GetObject("pctTahminiButceBtn.Image");
            pctTahminiButceBtn.Location = new Point(0, 0);
            pctTahminiButceBtn.Name = "pctTahminiButceBtn";
            pctTahminiButceBtn.Size = new Size(118, 50);
            pctTahminiButceBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTahminiButceBtn.TabIndex = 6;
            pctTahminiButceBtn.TabStop = false;
            // 
            // pnlNot
            // 
            pnlNot.BorderStyle = BorderStyle.FixedSingle;
            pnlNot.Controls.Add(pctNotBtn);
            pnlNot.Controls.Add(label6);
            pnlNot.Location = new Point(248, 6);
            pnlNot.Name = "pnlNot";
            pnlNot.Size = new Size(120, 80);
            pnlNot.TabIndex = 19;
            // 
            // pctNotBtn
            // 
            pctNotBtn.Cursor = Cursors.Hand;
            pctNotBtn.Dock = DockStyle.Top;
            pctNotBtn.Image = (Image)resources.GetObject("pctNotBtn.Image");
            pctNotBtn.Location = new Point(0, 0);
            pctNotBtn.Name = "pctNotBtn";
            pctNotBtn.Size = new Size(118, 50);
            pctNotBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNotBtn.TabIndex = 6;
            pctNotBtn.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 14.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(31, 52);
            label6.Name = "label6";
            label6.Size = new Size(50, 24);
            label6.TabIndex = 18;
            label6.Text = "Not";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlGorevli
            // 
            pnlGorevli.BorderStyle = BorderStyle.FixedSingle;
            pnlGorevli.Controls.Add(pctGorevli);
            pnlGorevli.Controls.Add(label9);
            pnlGorevli.Location = new Point(617, 6);
            pnlGorevli.Name = "pnlGorevli";
            pnlGorevli.Size = new Size(120, 80);
            pnlGorevli.TabIndex = 19;
            // 
            // pctGorevli
            // 
            pctGorevli.Cursor = Cursors.Hand;
            pctGorevli.Dock = DockStyle.Top;
            pctGorevli.Image = (Image)resources.GetObject("pctGorevli.Image");
            pctGorevli.Location = new Point(0, 0);
            pctGorevli.Name = "pctGorevli";
            pctGorevli.Size = new Size(118, 50);
            pctGorevli.SizeMode = PictureBoxSizeMode.StretchImage;
            pctGorevli.TabIndex = 6;
            pctGorevli.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Calligraphy", 14.25F);
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(17, 52);
            label9.Name = "label9";
            label9.Size = new Size(82, 24);
            label9.TabIndex = 18;
            label9.Text = "Görevli";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlGider
            // 
            pnlGider.BorderStyle = BorderStyle.FixedSingle;
            pnlGider.Controls.Add(pctGiderBtn);
            pnlGider.Controls.Add(label5);
            pnlGider.Location = new Point(125, 6);
            pnlGider.Name = "pnlGider";
            pnlGider.Size = new Size(120, 80);
            pnlGider.TabIndex = 19;
            // 
            // pctGiderBtn
            // 
            pctGiderBtn.Cursor = Cursors.Hand;
            pctGiderBtn.Dock = DockStyle.Top;
            pctGiderBtn.Image = (Image)resources.GetObject("pctGiderBtn.Image");
            pctGiderBtn.Location = new Point(0, 0);
            pctGiderBtn.Name = "pctGiderBtn";
            pctGiderBtn.Size = new Size(118, 50);
            pctGiderBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pctGiderBtn.TabIndex = 6;
            pctGiderBtn.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 14.25F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(25, 52);
            label5.Name = "label5";
            label5.Size = new Size(65, 24);
            label5.TabIndex = 18;
            label5.Text = "Gider";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1215, 784);
            Controls.Add(pnlEkran);
            Controls.Add(grpSonDurum);
            Controls.Add(grbNot);
            Controls.Add(pnlButonlar);
            Controls.Add(cmbDonem);
            Controls.Add(lblDonem);
            Controls.Add(cmbKoy);
            Controls.Add(lblKoy);
            Controls.Add(cmbIlce);
            Controls.Add(label1);
            Controls.Add(pnlBaslik);
            MaximizeBox = false;
            Name = "FrmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANA SAYFA";
            WindowState = FormWindowState.Maximized;
            Load += FrmAnaSayfa_Load;
            grbNot.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctNotButon).EndInit();
            grpSonDurum.ResumeLayout(false);
            grpSonDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBaslik.ResumeLayout(false);
            pnlBaslik.PerformLayout();
            pnlGelir.ResumeLayout(false);
            pnlGelir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctGelirBtn).EndInit();
            pnlButonlar.ResumeLayout(false);
            pnlDemirbas.ResumeLayout(false);
            pnlDemirbas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctDemirbas).EndInit();
            pnlEkButce.ResumeLayout(false);
            pnlEkButce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctEkButce).EndInit();
            pnlTahminiButce.ResumeLayout(false);
            pnlTahminiButce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctTahminiButceBtn).EndInit();
            pnlNot.ResumeLayout(false);
            pnlNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctNotBtn).EndInit();
            pnlGorevli.ResumeLayout(false);
            pnlGorevli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctGorevli).EndInit();
            pnlGider.ResumeLayout(false);
            pnlGider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctGiderBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBaslik;
        private Label label1;
        private ComboBox cmbIlce;
        private Label lblKoy;
        private Label lblDonem;
        private GroupBox grbNot;
        private RichTextBox rctxtNot;
        private GroupBox grpSonDurum;
        private Label lblSonuc;
        private Label lblToplamGider;
        private Label lblToplamGelir;
        private Panel panel1;
        private Panel pnlBaslik;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel pnlGelir;
        private PictureBox pctGelirBtn;
        private Label label4;
        private Panel pnlButonlar;
        private Panel pnlGider;
        private PictureBox pctGiderBtn;
        private Label label5;
        private Panel pnlNot;
        private PictureBox pctNotBtn;
        private Label label6;
        private Panel pnlTahminiButce;
        private PictureBox pctTahminiButceBtn;
        private Label label7;
        private Panel pnlDemirbas;
        private PictureBox pctDemirbas;
        private Label label8;
        private Panel pnlGorevli;
        private PictureBox pctGorevli;
        private Label label9;
        private Panel panel8;
        private PictureBox pctNotButon;
        private Label label10;
        public Panel pnlEkran;
        private Panel pnlEkButce;
        private Label label11;
        private PictureBox pctEkButce;
        public ComboBox cmbKoy;
        public ComboBox cmbDonem;
    }
}
