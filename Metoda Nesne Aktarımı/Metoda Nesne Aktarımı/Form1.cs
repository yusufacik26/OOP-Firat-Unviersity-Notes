using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metoda_Nesne_Aktarımı
{ 
    public partial class Form1: Form
    {    

        public Form1()
        {
            InitializeComponent();
        }

        private void PersonelBilgiDegistir(personel p)
        {
            p.ad = p.ad.ToUpper();
            p.soyad = p.soyad.ToUpper();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            personel p = new personel();

            p.ad = textBox1.Text;
            p.soyad = textBox2.Text;

            PersonelBilgiDegistir(p);

            textBox1.Text = p.ad;
            textBox2.Text = p.soyad;


        }
    }
    class personel
    {

        public string ad;
        public string soyad;

    }

}
