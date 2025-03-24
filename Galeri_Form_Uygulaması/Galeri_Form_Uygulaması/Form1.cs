using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri_Form_Uygulaması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;

            Araba yeniAraba = new Araba(marka, model, renk);

            Galeri galeri1 = new Galeri();

            galeri1.ArabaEkle(yeniAraba);

            listBox1.Items.Add(yeniAraba.ToString());
        }
    }
    class Araba
    {
        private string marka;
        private string model;
        private string renk;


        public Araba(string marka, string model, string renk)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;


        }

        public override string ToString()
        {
            return marka + "- " + model + " -" + renk;
        }


    }

    class Galeri
    {

        private List<Araba> arabalar = new List<Araba>(); // Galeriye arabalar sınıfından kolay araba ekleme

        public void ArabaEkle(Araba a)
        {
            arabalar.Add(a);

        }

        public List<Araba> Listele()
        {

            return arabalar;
        }
    }
}
