using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cagrilar cagrilar=new Cagrilar(1000);
        Cagrı cagri = new Cagrı();
        Arama aram = new Arama(1000);
        TicariMT ticariMT = new TicariMT();
        BireyselMT bireyselMT = new BireyselMT();
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            aram.AramaZamani = DateTime.Now;
            aram.Insert((object)txtMusteriID.Text);
            lbAramalar.Items.Add(aram.EkranaYaz());
            txtMusteriID.Text = "";
        }
        int BireyselSayac = 2;
        int TicariSayac = 2;
        
        private void btnCagriBaslat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aram.Listele());
            if (MTsec.Text == "BireyselMT" && BireyselSayac > 0)
            {
                cagrilar.AramaZamani = DateTime.Now;
                cagrilar.MusteriTip = MTsec.Text;
                cagrilar.MusteriID=Convert.ToInt32(aram.CagriDon());
                cagri.MT = bireyselMT;
                aram.Remove();
                cagrilar.Insert();
                lbCagrilar.Items.Add(cagrilar.Listele());
                BireyselSayac--;

            }
            else if (MTsec.Text == "BireyselMT")
                MessageBox.Show("Tüm Bireysel Temsilciler Hizmet Vermektedir.");
            if (MTsec.Text == "KurumsalMT" && TicariSayac > 0)
            {
                cagrilar.AramaZamani = DateTime.Now;
                cagrilar.MusteriTip = MTsec.Text;
                cagrilar.MusteriID = Convert.ToInt32(aram.CagriDon());
                cagri.MT = ticariMT;
                aram.Remove();
                cagrilar.Insert();
                lbCagrilar.Items.Add(cagrilar.Listele());
                TicariSayac--;

            }
            else if (MTsec.Text == "KurumsalMT")
                MessageBox.Show("Tüm Bireysel Temsilciler Hizmet Vermektedir.");
            MTsec.Text = "";
        }

        private void btnCagriBitir_Click(object sender, EventArgs e)
        {
            cagrilar.Notlar = txtNotlarr.Text;
            cagrilar.AramaZamani2= DateTime.Now;
            if(cagrilar.BireyselTicariKontrol())
                BireyselSayac++;
            else
                TicariSayac++;
            cagrilar.Remove();
            txtNotlarr.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKelimeAra_Click(object sender, EventArgs e)
        {
            txtBulunanKelime.Text = cagrilar.MetinAra(txtKontrolKelime.Text);
            lbBulunanKelimeler.Items.Add(cagrilar.MetinAra(txtKontrolKelime.Text));
            MessageBox.Show(cagrilar.CagriSureSırala());
            //string secili= listBox1.Items[listBox1.SelectedIndex].ToString();
            //listBox1.Items.Clear();
            //listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
