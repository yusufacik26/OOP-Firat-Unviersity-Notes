using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradview_Galeri_Uygulması_Tekrar
{
    public partial class Form1: Form
    {
        Galeri g;
        public Form1()
        {
            InitializeComponent();
             g = new Galeri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;

            Araba a = new Araba(marka, model, renk);

            

            g.ekle(a);
            MessageBox.Show("Ekleme Başarılı");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  // Eski elemanları temizle

            string[] arabaElemanları = g.arabaListele();

            foreach (var araba in arabaElemanları)
            {
                listBox1.Items.Add(araba);  // Elemanları listeye ekle
            }

        }
    }


    class Araba {

        public string marka;
        public string model;
        public string renk;


        public Araba(string marka,string model,string renk)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
}

    
    
    }

    class Galeri
    {
        public List<Araba> arabalar = new List<Araba>();


        public void ekle(Araba a)
        {

            arabalar.Add(a);

        }
        public void sat(Araba a)
        {

            if (arabalar.Contains(a))
            {
                arabalar.Remove(a);


            }

        }

        public string[] arabaListele()
        {
            string[] dizi = new string[arabalar.Count];

            for(int i = 0; i < arabalar.Count; i++)
            {

                dizi[i] = arabalar[i].marka +" "+ arabalar[i].model +" "+ arabalar[i].renk;

            }
            return dizi;


        }


        }


    }

