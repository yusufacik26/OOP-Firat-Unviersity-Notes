using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_b_konsol_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("taban sayısını girin...");

            double taban = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Üs sayısını giriniz");

            int us = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}^{1}={2}", taban, us, Math.Pow(taban, us));


        }
    }
}
