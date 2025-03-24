using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKonsolUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenAd = textBox1.Text;
            string girilenSoyad = textBox2.Text;

            ogrenci ogr = new ogrenci();

            ogr.ad = girilenAd.ToUpper();
            ogr.soyad = girilenSoyad.ToUpper();

            string ad = ogr.ad;
            string soyad = ogr.soyad;
            MessageBox.Show("Ad " + ad + " " + "soyad " + soyad);


        }
    }

    class ogrenci
    {
        public string ad;
        public string soyad;
    }
}
