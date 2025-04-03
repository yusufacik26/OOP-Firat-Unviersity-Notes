using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize24._2
{
    class Aylar
    {

        string[] ay = { "", "oca", "sub", "mar", "nis", "may", "haz", "tem", "agu", "eyl", "ekm", "kas", "arl" };


        public int ayBul(string girdi) {
        
            for(int i = 0; i < ay.Length; i++)
            {

                if(girdi == ay[i]) {
                    return i;
                }

            }
            return -1;
        }

        public int this[string girdi] //indexkleme yapıyor adamım
        {
            get { return ayBul(girdi); }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Aylar ay = new Aylar();
            while (true)
            {
                Console.Write("Herhangi bir ayın ilk üç harfini gir:"); string girdi = Console.ReadLine(); if (girdi == "cik") break;
                int aysirasi = ay[girdi];
                if (aysirasi > 0) Console.WriteLine("Girilen ay sırası:" + aysirasi); else Console.WriteLine("Geçersiz Giriş");
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız"); Console.ReadKey();
        }
    }
}
