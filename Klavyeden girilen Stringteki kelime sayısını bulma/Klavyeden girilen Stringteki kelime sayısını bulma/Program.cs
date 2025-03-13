using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_Stringteki_kelime_sayısını_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            String cumle;
            Console.WriteLine("Bir cümle girin");

            cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');

            Console.WriteLine("Cümledeki kelime sayısı " + kelimeler.Length);


        }
    }
}
