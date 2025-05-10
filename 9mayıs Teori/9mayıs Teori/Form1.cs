using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9mayıs_Teori
{
    interface Icalisabilen
    {
         string calis();




    }

    abstract class kisi
    {
        public string isim;
        public abstract string bilgiGoster(string isim); // eğer abstract olsaydı override etmek zorundaydık!!!
        

           

        


    }


    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { mudur m = new mudur();
            MessageBox.Show(m.calis());

        }
    }
}
