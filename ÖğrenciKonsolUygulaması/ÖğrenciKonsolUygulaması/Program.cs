using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciKonsolUygulaması
{

    class ogrenci
    {
        private string isim;
        private int numara;

        public ogrenci(string isim , int numara)
        {
            this.isim = isim;
            this.numara = numara;


        }

        public void Ogrenci_Bilgiler_Goster() { 
        
        Console.WriteLine($"Ogrenci Adi:{isim},Numara:{numara}");
        
        }


    }

    class ders
    {
        private string DersAdi;

        private int not;


        public ders(string DersAdi , int not)
        {
            this.not = not;
            this.DersAdi = DersAdi;


        }

        public void Ders_Bilgi_Goster() {

            Console.WriteLine($"Ders Adi:{DersAdi},not:{not}");
        
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            ogrenci o1 = new ogrenci("Yusuf AÇIK", 323);

            o1.Ogrenci_Bilgiler_Goster();

            ders d1 = new ders("NTP",90);

            d1.Ders_Bilgi_Goster();
        }
    }
}
