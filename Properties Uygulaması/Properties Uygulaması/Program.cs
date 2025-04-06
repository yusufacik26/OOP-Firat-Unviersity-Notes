using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Uygulaması
{
    class isci
    {
        private int kimlikno;

        public int Kimlikno {
            get { return kimlikno; }
            set { kimlikno = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            isci i = new isci();
            i.Kimlikno = 123;

            Console.WriteLine(i.Kimlikno);
        }
    }
}
