using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Çalışamam
{

    public partial class Form1: Form
    {
        galeri g;
        public Form1()
        {
            InitializeComponent();
            g = new galeri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;

            araba a = new araba(marka, model, renk);

            g.ekle(a);
            MessageBox.Show("Ekleme başarılı!!!");

            listBox1.Items.Clear();

            listBox1.Items.Add(a.marka+a.model+a.renk+); // bu şekilde de 2.buton olmadan listeye yazdırabiliriz

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] s = g.listele();

            for(int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);

            }
        }
    }



    class araba
    {
        public string marka;
        public string model;
        public string renk;

        public araba(string marka, string model, string renk)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
        }
    }



    class galeri
    {
        private List<araba> arabalar;

        public galeri()
        {
            arabalar = new List<araba>();


        }

        public void ekle(araba a)
        {
            arabalar.Add(a);
        }

        public void sil(araba a)
        {
            if (arabalar.Contains(a))
            {

                arabalar.Remove(a);

            }

        }

        public string[] listele()
        {
            string[] s = new string[arabalar.Count];


            for (int i = 0; i < s.Length; i++)
            {
                s[i] = arabalar[i].marka + " " + arabalar[i].model + " " + arabalar[i].renk;



            }
            return s;

        }

    }
}
