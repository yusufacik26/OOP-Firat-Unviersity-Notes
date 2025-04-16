using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevsim_eşleme
{
    class mevsim
    {

        public string[] mevsimler = { "", "oca", "sub", "mar", "nis", "may", "haz", "tem", "agu", "eyl", "eki", "kas", "ara" };

        public int mevsimBul(string girdi)
        {
            for(int i = 0; i < mevsimler.Length; i++)
            {
                if (mevsimler[i] == girdi) { return i; }


            }
            return -1;
        }

        public string this[string girdi]
        {
            get
            {
                int aySayi = mevsimBul(girdi);

                if (aySayi <= 2 || aySayi==12) { return "Kış"; }
                else if(aySayi>=3 && aySayi <= 5) { return "İlkBahar"; }
                else if (aySayi >= 6 && aySayi <= 8) { return "Yaz"; }
                else{ return "SonBahar"; }

            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            mevsim m = new mevsim();

             string mevsimi = m["oca"];
            Console.WriteLine("Mevsim: " +mevsimi );
        }
    }
}
