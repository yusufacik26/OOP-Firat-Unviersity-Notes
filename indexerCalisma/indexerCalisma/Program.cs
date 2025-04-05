using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerCalisma
{
    class dersler {

        public string[] ders= {" ", "mat", "tur", "fiz", "ing", "biy", "kim" };

        public int dersBul(string dersAdi)
        {

            for(int i= 0; i < ders.Length; i++)
            {

                if (ders[i] == dersAdi)
                {
                    return i;
                }

            }
            return -1;


        }
        public int this[string dersAdi]
        {

            get { return dersBul(dersAdi); }

        }
    
    
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            dersler d = new dersler();

            Console.WriteLine(d.dersBul("mat"));

        }
    }
}
