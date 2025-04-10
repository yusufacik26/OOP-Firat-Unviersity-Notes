using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemi
{
    class Ogrenci
    {
        public string ad { get; set; }
        public string Soyad { get; set; }
        public double vizeNotu;
        public double finalNotu;


        public double VizeNotu
        {
            get
            {
                return vizeNotu;



            }

            set
            {
                if ((value >= 0) && (value <= 100))
                {

                    vizeNotu = value;
                }





            }
        }

        public double FinalNotu{
            get { return finalNotu; }
            set { if(value>=0 && value <= 100) { finalNotu = value; } }
        }

        public double gecmeNotu
        {

            get
            {
                if (gecmeNotu < 50)
                {
                    return 49;

                }
                else { return vizeNotu * 0.4 + finalNotu * 0.6; }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

