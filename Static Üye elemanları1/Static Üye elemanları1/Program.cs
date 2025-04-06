using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Üye_elemanları1
{

    class statikMetod
    {
        public static void sMetod1() {

            Console.WriteLine("Statik Metod 1");

            }

        static statikMetod()
        {
            Console.WriteLine("Statik çalıştı");


        }

        public statikMetod()
        {

            Console.WriteLine("Statik olmayan çalıştı");

        }


}

    class Program
    {
        static void Main(string[] args)
        {

            statikMetod s = new statikMetod();
        }
    }
}
