using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();                                      
        }

        private void BtnAracOtoparkKayitSayfasi_Click(object sender, EventArgs e)
        {
            FrmAracOtoparkKaydi fr = new FrmAracOtoparkKaydi();
            fr.ShowDialog();
        }

        private void BtnAracOtoparkYerleri_Click(object sender, EventArgs e)
        {
            FrmAracOtoparkYerleri fr = new FrmAracOtoparkYerleri();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAracOtoparkCikisi fr = new FrmAracOtoparkCikisi();
            fr.ShowDialog();
        }

        private void BtnSatısList_Click(object sender, EventArgs e)
        {
            FrmSatisListeleme fr = new FrmSatisListeleme();
            fr.ShowDialog();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
