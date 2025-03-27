using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace noktalama_işaretlerini_silen_bir_form_uygulaması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\yusuf\\Desktop\\Yeni klasör\\Text.txt");

            String line = sr.ReadLine();

            while (line != null) {
                textBox1.Text += line.ToString();
                line = sr.ReadLine();
            }
            sr.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            char[] noktalama = {'.', ',', '*', '/', '<', '>', '?', '!' };


            string metin = textBox1.Text;
            string bos = "";
            for(int i = 0;i<metin.Length;i++)
            {
                bool varmi = false;

                for(int j = 0; j < noktalama.Length; j++)
                {
                    if (metin[i] == noktalama[j])
                    {
                        varmi = true;

                    }


                }

                if (!varmi)
                {
                    bos += metin[i];

                
                }
                textBox2.Text = bos;


            }

        }
    }
}
