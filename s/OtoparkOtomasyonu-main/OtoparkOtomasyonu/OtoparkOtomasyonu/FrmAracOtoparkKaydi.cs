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

namespace OtoparkOtomasyonu
{
    public partial class FrmAracOtoparkKaydi : Form
    {
        public FrmAracOtoparkKaydi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=Arac_Otopark;Integrated Security=True");

        private void FrmAracOtoparkKaydi_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Marka();
            Seri();
        }

        private void Seri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seribilgileri",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CmbSeri.Items.Add(read["seri"].ToString());  //Comboboxa seri bilgilerini yazdırma
            }
            baglanti.Close();
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {                                                              //Comboboxa marka bilgilerini yazdırma
                CmbMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BosAraclar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from aracdurumu WHERE durumu='BOŞ'", baglanti);
            SqlDataReader read = komut.ExecuteReader();   
            while (read.Read())
            {
                CmbParkYeri.Items.Add(read["parkyeri"].ToString());  //Parkyeri boş olanları combobox'a listeleme
            }
            baglanti.Close();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into arac_otopark_kaydi(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih)values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@tc", TxtTC.Text);
            komut.Parameters.AddWithValue("@ad", TxtAd.Text);              //Kullanıcının girilen bilgilerini veritabanına ekleme
            komut.Parameters.AddWithValue("@soyad", TxtSoyad.Text);                  
            komut.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@email", TxtEmail.Text);
            komut.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", CmbMarka.Text);
            komut.Parameters.AddWithValue("@seri", CmbSeri.Text);
            komut.Parameters.AddWithValue("@renk", TxtRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", CmbParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update aracdurumu set durumu='DOLU' where parkyeri='" + CmbParkYeri.SelectedItem+"'",baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kaydı Oluşturuldu.", "Kayıt");
            CmbParkYeri.Items.Clear();
            BosAraclar();
            CmbMarka.Items.Clear();
            Marka();
            CmbSeri.Items.Clear();
            foreach (Control item in grpKisi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpArac.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpArac.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnMarka_Click(object sender, EventArgs e)
        {
            FrmMarka fr = new FrmMarka();
            fr.ShowDialog();
        }

        private void BtnSeri_Click(object sender, EventArgs e)
        {
            FrmSeri fr = new FrmSeri();
            fr.ShowDialog();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSeri.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seribilgileri where marka ='"+CmbMarka.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CmbSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();

        }
    }
}
