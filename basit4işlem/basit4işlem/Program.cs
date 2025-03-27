using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basit4işlem
{
    class Program
    {
        static void Main(string[] args)
        {

            int secim;

            do {
                Console.WriteLine("İKİ sayıyı girin");

                int a = Convert.ToInt32(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İşlem seçimi");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Çıkarma");
                Console.WriteLine("3-Bölme");
                Console.WriteLine("4-çarpma");
                Console.WriteLine("0-Çıkış");

                secim = Convert.ToInt32(Console.ReadLine());


                switch (secim) {

                    case 1: Console.WriteLine("{0}+{1}={2}", a, b, (a + b)); break;
                    case 2: Console.WriteLine("{0}-{1}={2}", a, b, (a - b)); break;
                    case 3: Console.WriteLine("{0}/{1}={2}", a, b, (a / b)); break;
                    case 4: Console.WriteLine("{0}*{1}={2}", a, b, (a * b)); break;
                    case 0: Console.WriteLine("Çıkış seçildi"); break;
                    default: Console.WriteLine("Yanlış seçim"); break;

                } }

            while (secim != 0);
            Console.ReadLine();
            }
        }
    }


