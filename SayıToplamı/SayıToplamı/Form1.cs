using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıToplamı
{
    
    public partial class Form1: Form
    {
        string s;
        public Form1()
        {
            InitializeComponent();
            s = "";
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
            button6.Click += button1_Click;
            button7.Click += button1_Click;
            button8.Click += button1_Click;
            button9.Click += button1_Click;
            button10.Click += button1_Click;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i  = 0; i < s.Length; i++)
            {
                sum += (int)(s[i] - '0');


            }
            MessageBox.Show(Convert.ToString(sum));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            s += b.Text;

            textBox1.Text = s;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            s = "";
            textBox1.Text = s;
        }
    }
}
