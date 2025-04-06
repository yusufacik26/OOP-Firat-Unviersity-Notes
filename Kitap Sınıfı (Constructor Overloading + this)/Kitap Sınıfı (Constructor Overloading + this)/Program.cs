using Kitap_Sınıfı__Constructor_Overloading___this_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap_Sınıfı__Constructor_Overloading___this_
{
    class Kitap
    {
        public string ad;
        public string yazar;
        public int sayfa;

        public Kitap(string ad, string yazar, int sayfa)
        {
            this.ad = ad;
            this.yazar = yazar;
            this.sayfa = sayfa;

            Console.WriteLine($"Kitap: {ad}, Yazar: {yazar}, Sayfa: {sayfa}");
        }


        public Kitap(string yazar,int sayfa) : this("Bilinmiyor", yazar, sayfa)
        {
            Console.WriteLine("Kitap Adı bilgisi girilmedi");


        }

        public Kitap(string ad) : this(ad, "bilinmiyor", 100) {


            Console.WriteLine("Yazar Adı ve sayfa bilgisi girilmedi");

        }

        



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        //Kitap k1 = new Kitap("1984", "George Orwell", 328);
        Kitap k2 = new Kitap("Atatürk", 600);
        //Kitap k3 = new Kitap("Bilinmeyen Kitap");
    }
    }

