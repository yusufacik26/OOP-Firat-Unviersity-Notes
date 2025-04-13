using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1AKitapYazar__Kütüphane
{
    class yazar {

        public string isim { get; set; }

        public yazar(string isim    )
        {
            this.isim = isim;
        }
    }
    class kitap{
    
        public string ad{ get; set; }
        public yazar yazari{ get; set; }


        public kitap(string ad,yazar yazari)
        {

            this.ad = ad;
            this.yazari = yazari;


        }
    }


    class kütüphane
    {
        List<kitap> kitaplar = new List<kitap>();

        public void ekle(kitap yeniKitap)
        {
            if (!(kitaplar.Contains(yeniKitap)))
            {
                kitaplar.Add(yeniKitap);


            }   



        }

        public void listele()
        {

            foreach(kitap k in kitaplar)
            {
                Console.WriteLine("Kitap adı:" +k.ad+" "+" Kitap yazarı "+k.yazari.isim);


            }



        }




    }

    class Program
    {
        static void Main(string[] args)
        {
            yazar y1 = new yazar("ORHAN PAMUK");
            yazar y2 = new yazar("Ahmet Ümit");
            yazar y3 = new yazar("Halide Edip Adıvar");

            kitap k1 = new kitap("Bir bilim adamının romanı", y1);
            kitap k2 = new kitap("Sisli geceler", y2);
            kitap k3 = new kitap("Ateşten Gömlek", y3);

            kütüphane kütüp = new kütüphane();
            kütüp.ekle(k1);
            kütüp.ekle(k2);
            kütüp.ekle(k3);

            kütüp.listele();


        }
    }
}
