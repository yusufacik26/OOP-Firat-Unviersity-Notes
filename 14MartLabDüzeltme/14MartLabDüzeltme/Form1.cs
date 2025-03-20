using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14MartLabDüzeltme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\yusuf\\Desktop\\Yeni klasör\\Text.txt");
            String line = sr.ReadLine();

            while (line != null)
            {

                textBox1.Text += " " +line.ToString();
                line = sr.ReadLine();

            }


            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] noktalama = { '.', ',', ';', '%', '#', ' ', '*', '?', '!' };

            string metin = textBox1.Text;
            string temizMetin = "";

            foreach (char karakter in metin)
            {

                bool varMi = false;

                for (int i = 0; i < noktalama.Length; i++)
                {

                    if (karakter == noktalama[i])
                    {
                        varMi = true;


                    }

                }
                if (varMi == false)
                {
                    temizMetin += karakter;


                }
                textBox2.Text = temizMetin;
            }
        }
    }
}
