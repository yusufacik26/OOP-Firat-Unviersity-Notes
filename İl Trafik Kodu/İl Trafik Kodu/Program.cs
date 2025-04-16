using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İl_Trafik_Kodu
{
    class plaka
    {
        public string[] plakalar = { "", "Adana", "Adıyaman", "Afyon","Eskisehir", "İstanbul" };


        public int sehirBul(string sehir)
        {
            for(int i = 0; i < plakalar.Length; i++)
            {
                if (plakalar[i] == sehir) { return i; }


            }
            return -1;

        }

        public int this[string girdi]
        {
            get { return sehirBul(girdi); }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            plaka p = new plaka();

            Console.WriteLine(p.sehirBul("Eskisehir"));
        }
    }
}
