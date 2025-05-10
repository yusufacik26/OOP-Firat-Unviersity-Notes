using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mayıs_teori { 
    class araba {

        private string plaka;
        public string Plaka
        {
            set { plaka = value; }
            get { return plaka; }
        }
    
    
    }
    class Kisi
    {
        private string isim;
        private araba arac;
        public Kisi(string isim)
        {
            this.isim = isim;

        }
        public string Isim
        {
            set { isim = value; }
            get { return isim; }
        }

        public string Arac
        {
            get { return arac; }// Burayı Düzelt!!!!
        }

        public void KendiniTanit()
        {

            string intro = "Merhaba isimim " + isim;

            if (arac != null)
            {
                intro += arac.Plaka + " Plakalı aracım var";

            }
            Console.WriteLine(intro);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi("Yusuf Açık");
            k1.KendiniTanit();

            araba mustang = new araba();


        }
    }
}
