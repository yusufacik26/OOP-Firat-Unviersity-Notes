using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemberClass
{
    class cember {

        private double r;

        public cember(double r)
        {
            this.r = r;
        }

        public double YariCapVer() {

            return r;
        
        }

        public void YariCapAyarla(double yeniR) {

            if (yeniR > 0) {

                r = yeniR;
            }

            else { Console.WriteLine("Negatif Olamaz"); }
        
        }

        public double AlanHesapla() {

            return Math.PI * r * r;
        
        }

        public double CevreHesapla() {


            return Math.PI * 2 * r;
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cember c1 = new cember(3.5);

            Console.WriteLine(c1.CevreHesapla());
            Console.WriteLine(c1.AlanHesapla());
            Console.WriteLine(c1.YariCapVer());

            c1.YariCapAyarla(4.3);

            Console.WriteLine("Yeni Yarıçap == "+ c1.YariCapVer());
            Console.WriteLine("Yeni Alan == " + c1.AlanHesapla());
            Console.WriteLine("Yeni Çevre == " + c1.CevreHesapla());


        }
    }
}
