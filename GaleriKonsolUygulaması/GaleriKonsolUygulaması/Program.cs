using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriKonsolUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Araba
    {
        private string model;
        private string marka;
        private string renk;

        public Araba(string model, string marka,string renk)
        {
            this.model = model;
            this.marka = marka;
            this.renk = renk;


        }
        public override string ToString()
        {
            return marka+" - "+model+" - "renk;
        }



    }
}
