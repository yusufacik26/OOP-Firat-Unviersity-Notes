using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_veya_Non_Static_Olmak
{
    class Program
    {
        class Urun
        {
            public int id;
            public string ad;
            public int fiyat;

            public static int KDVoran;

            public void UrunYaz()
            {

                Console.WriteLine($"Ürün ID:{id}  Ürün ADI:{ad}  ÜrünFiyatı{fiyat}  KDV Oranı {KDVoran}");

            }

        }

        static void Main(string[] args)
        {
            Urun.KDVoran = 15;
            Urun klavye = new Urun();

            klavye.ad = "Logitech";
            klavye.id = 123;
            klavye.fiyat = 1200;

            klavye.UrunYaz();


            Urun mouse = new Urun();

            mouse.ad = "Rampage";
            mouse.id = 354;
            mouse.fiyat = 870;

            mouse.UrunYaz();

        }
    }
}
