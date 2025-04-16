using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renk_Kodu_Eşleştirme
{
    class renk
    {
        public string[] renkler = { "","kır","yes","sar","mor" };

        public int renkBul(string girilen)
        {
            for(int i = 0; i < renkler.Length; i++)
            {
                if (renkler[i] == girilen) { return i; }



            }

            return -1;
        }

        public int this[string girdi]
        {
            get { return renkBul(girdi); }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            renk r = new renk();

            Console.WriteLine(r.renkBul("yes"));
        }
    }
}
