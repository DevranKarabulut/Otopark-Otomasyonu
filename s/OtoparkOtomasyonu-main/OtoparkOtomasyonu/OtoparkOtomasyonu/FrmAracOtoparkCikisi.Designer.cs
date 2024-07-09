
namespace OtoparkOtomasyonu
{
    partial class FrmAracOtoparkCikisi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtParkYeri = new System.Windows.Forms.TextBox();
            this.CmbPlakaAra = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblGelisTarihi = new System.Windows.Forms.Label();
            this.LblCikisTarihi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblToplamTutar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.TxtSeri = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtParkYeri2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbParkYeri = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAracCikisi = new System.Windows.Forms.Button();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnPdfYazdir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtParkYeri);
            this.groupBox1.Controls.Add(this.CmbPlakaAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Park Bilgileri";
            // 
            // TxtParkYeri
            // 
            this.TxtParkYeri.Location = new System.Drawing.Point(98, 83);
            this.TxtParkYeri.Name = "TxtParkYeri";
            this.TxtParkYeri.Size = new System.Drawing.Size(147, 26);
            this.TxtParkYeri.TabIndex = 4;
            // 
            // CmbPlakaAra
            // 
            this.CmbPlakaAra.FormattingEnabled = true;
            this.CmbPlakaAra.Location = new System.Drawing.Point(98, 38);
            this.CmbPlakaAra.Name = "CmbPlakaAra";
            this.CmbPlakaAra.Size = new System.Drawing.Size(147, 28);
            this.CmbPlakaAra.TabIndex = 3;
            this.CmbPlakaAra.SelectedIndexChanged += new System.EventHandler(this.CmbPlakaAra_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Park Yeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka Ara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblGelisTarihi);
            this.groupBox2.Controls.Add(this.LblCikisTarihi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.LblToplamTutar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.LblSure);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(289, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ücretlendirme";
            // 
            // LblGelisTarihi
            // 
            this.LblGelisTarihi.AutoSize = true;
            this.LblGelisTarihi.ForeColor = System.Drawing.Color.Red;
            this.LblGelisTarihi.Location = new System.Drawing.Point(133, 22);
            this.LblGelisTarihi.Name = "LblGelisTarihi";
            this.LblGelisTarihi.Size = new System.Drawing.Size(0, 20);
            this.LblGelisTarihi.TabIndex = 2;
            // 
            // LblCikisTarihi
            // 
            this.LblCikisTarihi.AutoSize = true;
            this.LblCikisTarihi.ForeColor = System.Drawing.Color.Red;
            this.LblCikisTarihi.Location = new System.Drawing.Point(133, 62);
            this.LblCikisTarihi.Name = "LblCikisTarihi";
            this.LblCikisTarihi.Size = new System.Drawing.Size(0, 20);
            this.LblCikisTarihi.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Geliş Tarihi";
            // 
            // LblToplamTutar
            // 
            this.LblToplamTutar.AutoSize = true;
            this.LblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.LblToplamTutar.Location = new System.Drawing.Point(133, 143);
            this.LblToplamTutar.Name = "LblToplamTutar";
            this.LblToplamTutar.Size = new System.Drawing.Size(0, 20);
            this.LblToplamTutar.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Çıkış Tarihi";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.ForeColor = System.Drawing.Color.Red;
            this.LblSure.Location = new System.Drawing.Point(133, 101);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(0, 20);
            this.LblSure.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Toplam Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Süre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtPlaka);
            this.groupBox3.Controls.Add(this.TxtSeri);
            this.groupBox3.Controls.Add(this.TxtAd);
            this.groupBox3.Controls.Add(this.TxtMarka);
            this.groupBox3.Controls.Add(this.TxtTC);
            this.groupBox3.Controls.Add(this.TxtSoyad);
            this.groupBox3.Controls.Add(this.TxtParkYeri2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CmbParkYeri);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 230);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araç Bilgileri";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(368, 146);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(151, 26);
            this.TxtPlaka.TabIndex = 4;
            // 
            // TxtSeri
            // 
            this.TxtSeri.Location = new System.Drawing.Point(368, 101);
            this.TxtSeri.Name = "TxtSeri";
            this.TxtSeri.Size = new System.Drawing.Size(151, 26);
            this.TxtSeri.TabIndex = 4;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(98, 149);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(147, 26);
            this.TxtAd.TabIndex = 4;
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(368, 61);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(151, 26);
            this.TxtMarka.TabIndex = 4;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(98, 109);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(147, 26);
            this.TxtTC.TabIndex = 4;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(368, 21);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(151, 26);
            this.TxtSoyad.TabIndex = 4;
            // 
            // TxtParkYeri2
            // 
            this.TxtParkYeri2.Location = new System.Drawing.Point(98, 69);
            this.TxtParkYeri2.Name = "TxtParkYeri2";
            this.TxtParkYeri2.Size = new System.Drawing.Size(147, 26);
            this.TxtParkYeri2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "TC";
            // 
            // CmbParkYeri
            // 
            this.CmbParkYeri.FormattingEnabled = true;
            this.CmbParkYeri.Location = new System.Drawing.Point(98, 27);
            this.CmbParkYeri.Name = "CmbParkYeri";
            this.CmbParkYeri.Size = new System.Drawing.Size(147, 28);
            this.CmbParkYeri.TabIndex = 3;
            this.CmbParkYeri.SelectedIndexChanged += new System.EventHandler(this.CmbParkYeri_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Plaka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Seri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Park Yeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Park Yeri";
            // 
            // BtnAracCikisi
            // 
            this.BtnAracCikisi.BackColor = System.Drawing.Color.White;
            this.BtnAracCikisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAracCikisi.Location = new System.Drawing.Point(229, 423);
            this.BtnAracCikisi.Name = "BtnAracCikisi";
            this.BtnAracCikisi.Size = new System.Drawing.Size(94, 33);
            this.BtnAracCikisi.TabIndex = 0;
            this.BtnAracCikisi.Text = "Araç Çıkışı";
            this.BtnAracCikisi.UseVisualStyleBackColor = false;
            this.BtnAracCikisi.Click += new System.EventHandler(this.BtnAracCikisi_Click);
            // 
            // BtnIptal
            // 
            this.BtnIptal.BackColor = System.Drawing.Color.White;
            this.BtnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIptal.Location = new System.Drawing.Point(329, 423);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(94, 33);
            this.BtnIptal.TabIndex = 0;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = false;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnPdfYazdir
            // 
            this.BtnPdfYazdir.BackColor = System.Drawing.Color.White;
            this.BtnPdfYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPdfYazdir.Location = new System.Drawing.Point(122, 423);
            this.BtnPdfYazdir.Name = "BtnPdfYazdir";
            this.BtnPdfYazdir.Size = new System.Drawing.Size(101, 33);
            this.BtnPdfYazdir.TabIndex = 2;
            this.BtnPdfYazdir.Text = "PDF Yazdır";
            this.BtnPdfYazdir.UseVisualStyleBackColor = false;
            this.BtnPdfYazdir.Click += new System.EventHandler(this.BtnPdfYazdir_Click_1);
            // 
            // FrmAracOtoparkCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(624, 526);
            this.Controls.Add(this.BtnPdfYazdir);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnAracCikisi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAracOtoparkCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Çıkışı";
            this.Load += new System.EventHandler(this.FrmAracOtoparkCikisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnAracCikisi;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.TextBox TxtParkYeri;
        private System.Windows.Forms.ComboBox CmbPlakaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbParkYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.TextBox TxtSeri;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtParkYeri2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblGelisTarihi;
        private System.Windows.Forms.Label LblCikisTarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblToplamTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BtnPdfYazdir;
    }
}