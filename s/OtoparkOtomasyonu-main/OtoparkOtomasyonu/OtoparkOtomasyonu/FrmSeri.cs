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
    public partial class FrmSeri : Form
    {
        public FrmSeri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = (local); Initial Catalog = Arac_Otopark; Integrated Security = True");

        private void FrmSeri_Load(object sender, EventArgs e)
        {
            Marka();
        }

        private void Marka()
        {
            baglanti.Open();  //Comboboxa markayı yazdırma 
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CbmMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {                                            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seribilgileri (marka,seri) values('" +CbmMarka.Text+"','" +TxtSeri.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Markaya bağlı araç serisi eklendi.");
            TxtSeri.Clear();
            CbmMarka.Text = "";
            CbmMarka.Items.Clear();
            Marka();
        }
    }
}
