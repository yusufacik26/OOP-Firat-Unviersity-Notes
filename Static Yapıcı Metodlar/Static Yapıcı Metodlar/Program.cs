using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Yapıcı_Metodlar
{

    class Deneme
    {
         static Deneme()
        {
            Console.WriteLine("Static Metod çalıştı!!!!!");


        }

        public Deneme() {
            Console.WriteLine("Static OLMAYAN Metod çalıştı!!!!!");




        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Deneme d1 = new Deneme();

            Deneme d2 = new Deneme();
            Deneme d3 = new Deneme();
            Deneme d4 = new Deneme();
        }
    }
}
