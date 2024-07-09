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
    public partial class FrmAracOtoparkYerleri : Form
    {
        public FrmAracOtoparkYerleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=Arac_Otopark;Integrated Security=True");
        private void FrmAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            BoşParkYerleri();
            DoluParkYerleri();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {                                                     
                foreach (Control item in Controls)
                {
                    if (item is Button)     //Butomlara plaka yazdırma
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            item.Text = read["plaka"].ToString();
                        }

                    }
                }
            }
            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from aracdurumu", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {                                                       //Park yeri doluysa buton kırmızı renk alır.
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }

                    }
                }
            }
            baglanti.Close();
        }

        private void BoşParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;   //Butonların ismini değiştirme
                    item.Name = "P-" + sayac;
                    sayac++;
                }
            }

                }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
        }
        
    