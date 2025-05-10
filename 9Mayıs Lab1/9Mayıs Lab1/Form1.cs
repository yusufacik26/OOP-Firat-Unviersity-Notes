using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9Mayıs_Lab1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ICihaz[] cihazlar = { new TV(), new LCD(), new Projektör() };
            YayınYap.YayinYapma(cihazlar);
        }

    }
    interface ICihaz
    {
        void ac();
        void kapat();
        void goster(string Yazi);


    }
    class TV : ICihaz
    {
        void Ac() { Console.WriteLine("Tv Açıldı"); }
        void kapat() { Console.WriteLine("Tv kapandı"); }

        void Goster(string Yazi) { }

        public void ac()
        {
            throw new NotImplementedException();
        }

        void ICihaz.kapat()
        {
            kapat();
        }

        public void goster(string Yazi)
        {
            throw new NotImplementedException();
        }
    }


    class LCD : ICihaz
    {
        void Ac() { Console.WriteLine("Tv Açıldı"); }
        void kapat() { Console.WriteLine("Tv kapandı"); }

        void Goster(string Yazi) { Console.WriteLine("Projektör"); }

        public void ac()
        {
            throw new NotImplementedException();
        }

        void ICihaz.kapat()
        {
            kapat();
        }

        public void goster(string Yazi)
        {
            throw new NotImplementedException();
        }
    }

    class Projektör : ICihaz
    {



        void Goster(string Yazi) { Console.WriteLine("Projektör" + Yazi); }

        public void ac()
        {
            { Console.WriteLine("Projektör  Açıldı"); }
        }

        void kapat()
        {
            Console.WriteLine("Projektör kapandı");

        }

        public void goster(string Yazi)
        {
            throw new NotImplementedException();
        }

        void ICihaz.ac()
        {
            throw new NotImplementedException();
        }

        void ICihaz.kapat()
        {
            kapat();
        }

        void ICihaz.goster(string Yazi)
        {
            throw new NotImplementedException();
        }
    }

    class YayınYap
    {
        public static void YayinYapma(ICihaz[] cihazlar)
        {
            void YayınYapma()
            {
                foreach (ICihaz c in cihazlar)
                {
                    c.ac();
                    c.goster("Test Yayını");
                    c.kapat();
                    Console.WriteLine("-------------------");

                }

            }


        }


    }
}


