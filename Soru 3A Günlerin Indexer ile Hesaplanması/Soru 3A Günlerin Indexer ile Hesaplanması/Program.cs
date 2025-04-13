using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3A_Günlerin_Indexer_ile_Hesaplanması
{

    class gunler
    {
        string[] gun = { "", "pzt", "sal", "car", "per", "cum", "cmt", "paz" };

        public int gunBul(string aranan)
        {
            for(int i=0;i<gun.Length; i++)
            {
                if (aranan.Equals(gun[i])){

                    return i;
                }
            }
            return -1;

        }

        public int this[string isim]
        {

            get { return gunBul(isim); }

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            gunler g = new gunler();
            Console.WriteLine("Gün giriniz:");
            string giris = Console.ReadLine();
            int sonuc = g[giris];
            Console.WriteLine(sonuc > 0 ? "Sırası: " + sonuc : "Geçersiz gün");
        }
    }
}
