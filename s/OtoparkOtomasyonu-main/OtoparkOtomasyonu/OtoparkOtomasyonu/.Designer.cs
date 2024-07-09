
namespace OtoparkOtomasyonu
{
    partial class FrmAnaSayfa
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
            this.BtnAracOtoparkKayitSayfasi = new System.Windows.Forms.Button();
            this.BtnAracOtoparkYerleri = new System.Windows.Forms.Button();
            this.BtnOtoparkCikis = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnSatısList = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.arac_OtoparkDataSet1 = new OtoparkOtomasyonu.Arac_OtoparkDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_OtoparkDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAracOtoparkKayitSayfasi
            // 
            this.BtnAracOtoparkKayitSayfasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAracOtoparkKayitSayfasi.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAracOtoparkKayitSayfasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAracOtoparkKayitSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracOtoparkKayitSayfasi.Location = new System.Drawing.Point(62, 42);
            this.BtnAracOtoparkKayitSayfasi.Name = "BtnAracOtoparkKayitSayfasi";
            this.BtnAracOtoparkKayitSayfasi.Size = new System.Drawing.Size(338, 37);
            this.BtnAracOtoparkKayitSayfasi.TabIndex = 0;
            this.BtnAracOtoparkKayitSayfasi.Text = "Araç Otopark Kayıt";
            this.BtnAracOtoparkKayitSayfasi.UseVisualStyleBackColor = false;
            this.BtnAracOtoparkKayitSayfasi.Click += new System.EventHandler(this.BtnAracOtoparkKayitSayfasi_Click);
            // 
            // BtnAracOtoparkYerleri
            // 
            this.BtnAracOtoparkYerleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAracOtoparkYerleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAracOtoparkYerleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracOtoparkYerleri.Location = new System.Drawing.Point(62, 97);
            this.BtnAracOtoparkYerleri.Name = "BtnAracOtoparkYerleri";
            this.BtnAracOtoparkYerleri.Size = new System.Drawing.Size(338, 37);
            this.BtnAracOtoparkYerleri.TabIndex = 0;
            this.BtnAracOtoparkYerleri.Text = "Araç Otopark Yerleri";
            this.BtnAracOtoparkYerleri.UseVisualStyleBackColor = false;
            this.BtnAracOtoparkYerleri.Click += new System.EventHandler(this.BtnAracOtoparkYerleri_Click);
            // 
            // BtnOtoparkCikis
            // 
            this.BtnOtoparkCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnOtoparkCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOtoparkCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOtoparkCikis.Location = new System.Drawing.Point(62, 154);
            this.BtnOtoparkCikis.Name = "BtnOtoparkCikis";
            this.BtnOtoparkCikis.Size = new System.Drawing.Size(338, 37);
            this.BtnOtoparkCikis.TabIndex = 0;
            this.BtnOtoparkCikis.Text = "Araç Otopark Çıkış";
            this.BtnOtoparkCikis.UseVisualStyleBackColor = false;
            this.BtnOtoparkCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(62, 269);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(338, 37);
            this.BtnCikis.TabIndex = 0;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnSatısList
            // 
            this.BtnSatısList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSatısList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSatısList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatısList.Location = new System.Drawing.Point(62, 210);
            this.BtnSatısList.Name = "BtnSatısList";
            this.BtnSatısList.Size = new System.Drawing.Size(338, 37);
            this.BtnSatısList.TabIndex = 1;
            this.BtnSatısList.Text = "Satış Listeleme Sayfası";
            this.BtnSatısList.UseVisualStyleBackColor = false;
            this.BtnSatısList.Click += new System.EventHandler(this.BtnSatısList_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.arac_OtoparkDataSet1;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // arac_OtoparkDataSet1
            // 
            this.arac_OtoparkDataSet1.DataSetName = "Arac_OtoparkDataSet1";
            this.arac_OtoparkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::OtoparkOtomasyonu.Properties.Resources.otopark_yol_cizgileri;
            this.ClientSize = new System.Drawing.Size(445, 347);
            this.Controls.Add(this.BtnSatısList);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnOtoparkCikis);
            this.Controls.Add(this.BtnAracOtoparkYerleri);
            this.Controls.Add(this.BtnAracOtoparkKayitSayfasi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Otomasyonu Anasayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_OtoparkDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAracOtoparkKayitSayfasi;
        private System.Windows.Forms.Button BtnAracOtoparkYerleri;
        private System.Windows.Forms.Button BtnOtoparkCikis;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnSatısList;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Arac_OtoparkDataSet1 arac_OtoparkDataSet1;
    }
}

