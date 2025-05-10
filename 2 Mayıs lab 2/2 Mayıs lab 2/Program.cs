using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mayıs_lab_2
{

    interface IAnaInterface
    {
        void metod1();

    }

    interface ITuretilenInterface : IAnaInterface
    {
        void metod2();


    }

    class denemeClass : ITuretilenInterface
    {
        public void metod2() { Console.WriteLine("Türetilen arayüzden metod2 çalıştı"); }
        public void metod1() { Console.WriteLine("Ana arayüzden metod1 çalıştı"); }


    }
    class Program
    {
        static void Main(string[] args)
        {
            denemeClass dc = new denemeClass();

            dc.metod1();
            dc.metod2();

        }
    }
}
