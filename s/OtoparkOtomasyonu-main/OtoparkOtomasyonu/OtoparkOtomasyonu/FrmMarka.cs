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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=Arac_Otopark;Integrated Security=True");
        private void FrmMarka_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {    //Marka ekleme komutu
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into markabilgileri(marka) values('" + TxtMarka.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Eklendi.");
            TxtMarka.Clear();
        }
    }
}
