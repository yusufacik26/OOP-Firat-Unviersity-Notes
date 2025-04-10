using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renkler_Indexer
{
    class renkler
    {
        string[] renk = { "", "mav", "yeş", "sar", "mor", "tur", "bor" };

        public int renkBul(string renkGirilen)
        {

            for(int i =0; i < renk.Length; i++)
            {
                if (renkGirilen == renk[i])
                {
                    return i;

                }


            }
            return -1;
        }

        public int this[string girilenAy]
        {
            get { return renkBul(girilenAy); }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            renkler r = new renkler();

            Console.WriteLine(r.renkBul("mav"));

        }
    }
}
