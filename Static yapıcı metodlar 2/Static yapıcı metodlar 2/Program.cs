using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_yapıcı_metodlar_2
{

    class Oyuncu
    {
        static int toplam;

        public Oyuncu()
        {
            toplam++;
            Console.WriteLine("Toplam Oyuncu " + toplam);


        }

        static Oyuncu() {
            Console.WriteLine("Oyun Başladı!!!!!");
        }


        ~Oyuncu()
        {
            Console.WriteLine("Bir Oyuncu Ayrıldı!!!");
            toplam--;



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu yusuf = new Oyuncu();
            Oyuncu emir = new Oyuncu();
            Oyuncu semra = new Oyuncu();
            Oyuncu musa = new Oyuncu();

        }
    }
}
