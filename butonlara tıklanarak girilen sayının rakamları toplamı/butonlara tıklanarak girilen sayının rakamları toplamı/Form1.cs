using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butonlara_tıklanarak_girilen_sayının_rakamları_toplamı
{
    public partial class Form1: Form
    {
        String s;
        public Form1()
        {
            InitializeComponent();
            s = "";
            button3.Click += button12_Click;
            button4.Click += button12_Click;
            button5.Click += button12_Click;
            button6.Click += button12_Click;
            button7.Click += button12_Click;
            button8.Click += button12_Click;
            button9.Click += button12_Click;
            button10.Click += button12_Click;
            button11.Click += button12_Click;
            button12.Click += button12_Click;



        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            s = s + b.Text;
            textBox1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = "";
            textBox1.Text = s;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int top = 0;

            for(int i = 0; i < s.Length; i++)
            {
                
                top += (s[i]-'0');


            }
            MessageBox.Show(Convert.ToString(top));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
