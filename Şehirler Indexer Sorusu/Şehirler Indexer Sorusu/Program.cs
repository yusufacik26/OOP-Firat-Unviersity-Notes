using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şehirler_Indexer_Sorusu
{
    class sehir
    {
        string[] sehirler = { "", "eskisehir", "ankara", "istanbul", "izmir", "bursa"};

        public int sehirBul(string s)
        {
            for(int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == s) { return i; }


            }
            return -1;

        }

        public int this[string s]
        {
            get { return sehirBul(s); }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
