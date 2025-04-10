using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para_Üstü_Buton_uygulaması
{
    public partial class Form1: Form
    {
        int s = 0;
        public Form1()
        {
            InitializeComponent();
            
            button2.Click+=button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int deger = Convert.ToInt32(b.Text);

            s += deger;

            textBox1.Text = s.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int miktar = Convert.ToInt32(textBox1.Text);
            int[] banknotlar = { 200, 100, 50, 20, 10 };

            foreach(int banknot in banknotlar)
            {
                int adet = miktar / banknot;

                if (adet > 0){
                    listBox1.Items.Add($"{banknot} TL x {adet}");
                    miktar %= banknot;
                }


            }
        }
    }
}
