using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Sonradan eklenen kütüphaneler
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using iText.Kernel.Utils;
using System.IO;
using iText.Layout.Properties;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PdfSharp.Drawing;
using Org.BouncyCastle.Asn1.Pkcs;
using static System.Net.Mime.MediaTypeNames;
//---------------

namespace OtoparkOtomasyonu
{
    public partial class FrmAracOtoparkCikisi : Form
    {
        public FrmAracOtoparkCikisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=Arac_Otopark;Integrated Security=True");

        private void FrmAracOtoparkCikisi_Load(object sender, EventArgs e)
        {

            DoluYerler();
            Plakalar();
            timer1.Enabled = true;
        }

        private void Plakalar()                          //Comboboxa plakaları yazdırma
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CmbPlakaAra.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        private void DoluYerler()           //Comboboxa dolu yerleri yazdırma
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from aracdurumu where durumu='DOLU'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CmbParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void CmbPlakaAra_SelectedIndexChanged(object sender, EventArgs e)  //Seçilen plakaın yerini yazdırma
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi where plaka ='" + CmbPlakaAra.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtParkYeri.Text = read["parkyeri"].ToString();
            }
            baglanti.Close();
        }

        private void CmbParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM arac_otopark_kaydi WHERE parkyeri=@parkyeri", baglanti);
                komut.Parameters.AddWithValue("@parkyeri", CmbParkYeri.SelectedItem);
                SqlDataReader read = komut.ExecuteReader();
                if (read.Read())
                {
                    TxtParkYeri2.Text = read["parkyeri"].ToString();  // Veritabanındaki bilgileri textboxlara yazdırma
                    TxtTC.Text = read["tc"].ToString();
                    TxtAd.Text = read["ad"].ToString();
                    TxtSoyad.Text = read["soyad"].ToString();
                    TxtMarka.Text = read["marka"].ToString();
                    TxtSeri.Text = read["seri"].ToString();
                    TxtPlaka.Text = read["plaka"].ToString();
                    LblGelisTarihi.Text = read["tarih"].ToString();
                }
                baglanti.Close();

                // Örnek bir çıkış tarihi giriyoruz, gerçek uygulamada bu kullanıcıdan alınmalı
                LblCikisTarihi.Text = DateTime.Now.ToString(); // Çıkış tarihini şimdi olarak alıyoruz, gerçek uygulamada bu kullanıcıdan alınmalı

                // Giriş ve çıkış tarihlerini kontrol et
                if (DateTime.TryParse(LblGelisTarihi.Text, out DateTime gelis) && DateTime.TryParse(LblCikisTarihi.Text, out DateTime cikis))
                {
                    TimeSpan fark = cikis - gelis;
                    double toplamSaat = fark.TotalHours;
                    double toplamDakika = fark.TotalMinutes;

                    // Saat ve dakika olarak gösterim
                    LblSure.Text = $"{fark.Hours:D2} saat {fark.Minutes:D2} dakika";

                    // Toplam tutarı hesapla
                    double toplamTutar;
                    if (toplamSaat < 1)
                    {
                        toplamTutar = 50.00;
                    }
                    else if (toplamSaat < 2)
                    {
                        toplamTutar = 75.00;
                    }
                    else if (toplamSaat < 3)
                    {
                        toplamTutar = 100.00;
                    }
                    else if (toplamSaat < 4)
                    {
                        toplamTutar = 200.00;
                    }
                    else if (toplamSaat < 24)
                    {
                        toplamTutar = 1600.00;
                    }
                    else if (toplamSaat < 72)
                    {
                        toplamTutar = 4500.00;
                    }
                    else if (toplamSaat < 360)
                    {
                        toplamTutar = 20000.00;
                    }
                    else
                    {
                        toplamTutar = 40000.00;
                    }

                    LblToplamTutar.Text = toplamTutar.ToString("0.00") + " TL";
                }
                else
                {
                    MessageBox.Show("Tarih formatı geçersiz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            LblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void BtnAracCikisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();  //Çıkış yapan aracın kayıt bilgilerini silme 
            SqlCommand komut = new SqlCommand("delete  from arac_otopark_kaydi where plaka='" + TxtPlaka.Text + "'", baglanti);
            komut.ExecuteNonQuery();

            //Çıkış yapan aracın park yerini boş olarak güncelleme
            SqlCommand komut2 = new SqlCommand("update  aracdurumu set durumu='BOŞ' where parkyeri='" + TxtParkYeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            //Çıkış yaptığı zaman bilgilerini alma
            SqlCommand komut3 = new SqlCommand("insert into satis(parkyeri,plaka,gelis_tarihi,cikis_tarihi,sure,tutar) values (@parkyeri,@plaka,@gelis_tarihi,@cikis_tarihi,@sure,@tutar)", baglanti);
            komut3.Parameters.AddWithValue("@parkyeri", TxtParkYeri2.Text);
            komut3.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            komut3.Parameters.AddWithValue("@gelis_tarihi", LblGelisTarihi.Text);
            komut3.Parameters.AddWithValue("@cikis_tarihi", LblCikisTarihi.Text);
            komut3.Parameters.AddWithValue("@sure", (LblSure.Text));
            komut3.Parameters.AddWithValue("@tutar", (LblToplamTutar.Text));
            

            baglanti.Close();
            MessageBox.Show("Araç Çıkışı Yapıldı");
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    TxtParkYeri.Text = "";
                    CmbParkYeri.Text = "";
                    CmbPlakaAra.Text = "";
                }
            }
            CmbPlakaAra.Items.Clear();
            CmbParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void BtnPdfYazdir_Click_1(object sender, EventArgs e)
        {
            
                // Verileri TextBox kontrollerinden al
                string tc = TxtTC.Text;
                string ad = TxtAd.Text;
                string soyad = TxtSoyad.Text;
                string plaka = TxtPlaka.Text;
                string marka = TxtMarka.Text;
                string seri = TxtSeri.Text;
                string parkyeri = TxtParkYeri.Text;
                string giristarihi = LblGelisTarihi.Text;
                string cikistarihi = LblCikisTarihi.Text;
                string sure = LblSure.Text;
                string tutar = LblToplamTutar.Text;

                // PDF dosyası oluşturma işlemleri
                string dosyaYolu = "PDF\\OtoparkRaporu.pdf";
                PdfWriter yazdir = new PdfWriter(dosyaYolu);
                PdfDocument pdfDokuman = new PdfDocument(yazdir);
                pdfDokuman.AddNewPage();
                Document dokuman = new Document(pdfDokuman);

                // Font oluşturma
                PdfFont turkceFont = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN, "CP1254");
                dokuman.SetFont(turkceFont);

                // Başlık ekleme
                Paragraph baslik = new Paragraph("Otopark Raporu")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20)
                    .SetBold();
                dokuman.Add(baslik);

                // Boşluk ekleme
                dokuman.Add(new Paragraph("\n"));

                // Kişisel Bilgiler Tablosu
                Table personalTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 3 })).UseAllAvailableWidth();
                personalTable.AddCell(CreateCell("TC", true));
                personalTable.AddCell(CreateCell(tc));
                personalTable.AddCell(CreateCell("Ad", true));
                personalTable.AddCell(CreateCell(ad));
                personalTable.AddCell(CreateCell("Soyad", true));
                personalTable.AddCell(CreateCell(soyad));
                personalTable.AddCell(CreateCell("Plaka", true));
                personalTable.AddCell(CreateCell(plaka));
                personalTable.AddCell(CreateCell("Marka", true));
                personalTable.AddCell(CreateCell(marka));
                personalTable.AddCell(CreateCell("Seri", true));
                personalTable.AddCell(CreateCell(seri));
                dokuman.Add(personalTable);

                // Boşluk ekleme
                dokuman.Add(new Paragraph("\n"));

                // Park Detayları Tablosu
                Table detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 3 })).UseAllAvailableWidth();
                detailsTable.AddCell(CreateCell("Park Yeri", true));
                detailsTable.AddCell(CreateCell(parkyeri));
                detailsTable.AddCell(CreateCell("Giriş Tarihi", true));
                detailsTable.AddCell(CreateCell(giristarihi));
                detailsTable.AddCell(CreateCell("Çıkış Tarihi", true));
                detailsTable.AddCell(CreateCell(cikistarihi));
                detailsTable.AddCell(CreateCell("Süre", true));
                detailsTable.AddCell(CreateCell(sure));
                detailsTable.AddCell(CreateCell("Toplam Tutar", true));
                detailsTable.AddCell(CreateCell(tutar));
                dokuman.Add(detailsTable);

                // PDF dosyasını kapatma
                dokuman.Close();

                MessageBox.Show("PDF dosyası başarıyla oluşturuldu: " + dosyaYolu);
            }

            private Cell CreateCell(string content, bool isHeader = false)
            {
                Cell cell = new Cell().Add(new Paragraph(content));
                if (isHeader)
                {
                    cell.SetBold();
                    cell.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                }
                return cell;
            }
        }
    }
