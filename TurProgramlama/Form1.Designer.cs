namespace TurProgramlama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.lblSonucKar = new System.Windows.Forms.Label();
            this.lblSonucKisiSayisi = new System.Windows.Forms.Label();
            this.lblSonucOtobus = new System.Windows.Forms.Label();
            this.lblOtobus = new System.Windows.Forms.Label();
            this.lblKar = new System.Windows.Forms.Label();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblKisi = new System.Windows.Forms.Label();
            this.lblTurSecenegi = new System.Windows.Forms.Label();
            this.pctKar = new System.Windows.Forms.PictureBox();
            this.lblBosKoltuk = new System.Windows.Forms.Label();
            this.lblSonucBosKoltuk = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSonucBosKoltuk);
            this.groupBox1.Controls.Add(this.lblBosKoltuk);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtKisi);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.lblSonucKar);
            this.groupBox1.Controls.Add(this.lblSonucKisiSayisi);
            this.groupBox1.Controls.Add(this.lblSonucOtobus);
            this.groupBox1.Controls.Add(this.lblOtobus);
            this.groupBox1.Controls.Add(this.lblKar);
            this.groupBox1.Controls.Add(this.lblKisiSayisi);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.lblKisi);
            this.groupBox1.Controls.Add(this.lblTurSecenegi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tur Detayı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(101, 52);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(107, 20);
            this.txtKisi.TabIndex = 10;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Şehiriçi",
            "Şehirdışı"});
            this.cmbTur.Location = new System.Drawing.Point(101, 25);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(107, 21);
            this.cmbTur.TabIndex = 9;
            this.cmbTur.Text = "Lütfen Seçiniz..";
            // 
            // lblSonucKar
            // 
            this.lblSonucKar.AutoSize = true;
            this.lblSonucKar.Location = new System.Drawing.Point(211, 172);
            this.lblSonucKar.Name = "lblSonucKar";
            this.lblSonucKar.Size = new System.Drawing.Size(62, 13);
            this.lblSonucKar.TabIndex = 8;
            this.lblSonucKar.Text = "Bekleniyor..";
            // 
            // lblSonucKisiSayisi
            // 
            this.lblSonucKisiSayisi.AutoSize = true;
            this.lblSonucKisiSayisi.Location = new System.Drawing.Point(211, 124);
            this.lblSonucKisiSayisi.Name = "lblSonucKisiSayisi";
            this.lblSonucKisiSayisi.Size = new System.Drawing.Size(62, 13);
            this.lblSonucKisiSayisi.TabIndex = 7;
            this.lblSonucKisiSayisi.Text = "Bekleniyor..";
            // 
            // lblSonucOtobus
            // 
            this.lblSonucOtobus.AutoSize = true;
            this.lblSonucOtobus.Location = new System.Drawing.Point(211, 102);
            this.lblSonucOtobus.Name = "lblSonucOtobus";
            this.lblSonucOtobus.Size = new System.Drawing.Size(62, 13);
            this.lblSonucOtobus.TabIndex = 6;
            this.lblSonucOtobus.Text = "Bekleniyor..";
            // 
            // lblOtobus
            // 
            this.lblOtobus.AutoSize = true;
            this.lblOtobus.Location = new System.Drawing.Point(18, 102);
            this.lblOtobus.Name = "lblOtobus";
            this.lblOtobus.Size = new System.Drawing.Size(77, 13);
            this.lblOtobus.TabIndex = 5;
            this.lblOtobus.Text = "Otobüs Sayısı :";
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Location = new System.Drawing.Point(18, 172);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(29, 13);
            this.lblKar.TabIndex = 4;
            this.lblKar.Text = "Kâr :";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(18, 124);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(59, 13);
            this.lblKisiSayisi.TabIndex = 3;
            this.lblKisiSayisi.Text = "Kişi Sayısı :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(214, 28);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(138, 44);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.Location = new System.Drawing.Point(36, 55);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(59, 13);
            this.lblKisi.TabIndex = 1;
            this.lblKisi.Text = "Kişi Sayısı :";
            // 
            // lblTurSecenegi
            // 
            this.lblTurSecenegi.AutoSize = true;
            this.lblTurSecenegi.Location = new System.Drawing.Point(18, 28);
            this.lblTurSecenegi.Name = "lblTurSecenegi";
            this.lblTurSecenegi.Size = new System.Drawing.Size(77, 13);
            this.lblTurSecenegi.TabIndex = 0;
            this.lblTurSecenegi.Text = "Tur Seçeneği :";
            // 
            // pctKar
            // 
            this.pctKar.Location = new System.Drawing.Point(376, 12);
            this.pctKar.Name = "pctKar";
            this.pctKar.Size = new System.Drawing.Size(185, 210);
            this.pctKar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctKar.TabIndex = 1;
            this.pctKar.TabStop = false;
            // 
            // lblBosKoltuk
            // 
            this.lblBosKoltuk.AutoSize = true;
            this.lblBosKoltuk.Location = new System.Drawing.Point(18, 147);
            this.lblBosKoltuk.Name = "lblBosKoltuk";
            this.lblBosKoltuk.Size = new System.Drawing.Size(61, 13);
            this.lblBosKoltuk.TabIndex = 11;
            this.lblBosKoltuk.Text = "Boş Koltuk:";
            // 
            // lblSonucBosKoltuk
            // 
            this.lblSonucBosKoltuk.AutoSize = true;
            this.lblSonucBosKoltuk.Location = new System.Drawing.Point(211, 147);
            this.lblSonucBosKoltuk.Name = "lblSonucBosKoltuk";
            this.lblSonucBosKoltuk.Size = new System.Drawing.Size(62, 13);
            this.lblSonucBosKoltuk.TabIndex = 12;
            this.lblSonucBosKoltuk.Text = "Bekleniyor..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 240);
            this.Controls.Add(this.pctKar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tur Programlama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblSonucKar;
        private System.Windows.Forms.Label lblSonucKisiSayisi;
        private System.Windows.Forms.Label lblSonucOtobus;
        private System.Windows.Forms.Label lblOtobus;
        private System.Windows.Forms.Label lblKar;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKisi;
        private System.Windows.Forms.Label lblTurSecenegi;
        private System.Windows.Forms.PictureBox pctKar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSonucBosKoltuk;
        private System.Windows.Forms.Label lblBosKoltuk;
    }
}

