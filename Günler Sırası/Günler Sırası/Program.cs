using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Günler_Sırası
{class gunler
    {
        public string[] gun = {" ","pzt", "sal", "car", "per", "cum", "cmt", "paz" };

        public int gunBul(string girdi)
        {
            for(int i = 0; i < gun.Length; i++)
            {
                if (gun[i] == girdi)
                {

                    return i;
                }
                
            }
            return -1;

        }

        public int this[string girilen]
        {
            get { return gunBul(girilen); }


        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            gunler gun = new gunler();

            while (true)
            {
                Console.Write("Herhangi bir günün ilk üç harfini gir (çıkmak için 'cik' yaz): ");
                string girdi = Console.ReadLine();

                if (girdi.ToLower() == "cik")
                    break;

                int sirasi = gun[girdi];

                if (sirasi != -1)
                    Console.WriteLine("Girilen gün haftanın " + sirasi + ". günü.");
                else
                    Console.WriteLine("Geçersiz giriş.");
            }

            Console.WriteLine("Program sona erdi. Devam etmek için bir tuşa bas.");
        }
    }
}
