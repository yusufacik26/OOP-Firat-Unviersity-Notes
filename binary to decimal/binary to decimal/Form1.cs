using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary_to_decimal
{
    public partial class Form1: Form
    {
        string s;
        public Form1()
        {
            InitializeComponent();
            s = "";
            button2.Click += button1_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double top = 0;
            int j = 0;
            for(int i = s.Length-1; i >= 0; i--)
            {
                int rakam = Convert.ToInt32(s[i] - '0');

                double sonuc = (Math.Pow(2, j)*rakam);

                j++;
                top += sonuc;


            }
            textBox1.Text = Convert.ToString(top);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            s += s + b.Text;
            textBox1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
