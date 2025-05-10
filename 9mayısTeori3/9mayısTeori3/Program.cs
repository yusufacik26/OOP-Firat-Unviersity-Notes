using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9mayısTeori3
{
    interface ICihaz
    {
        void ac();
        void kapat();
        void goster(string Yazi);


    }
    class TV : ICihaz
    {
        void Ac() { Console.WriteLine("Tv Açıldı"); }
        void kapat() { Console.WriteLine("Tv kapandı"); }

        void Goster(string Yazi) { }

        public void ac()
        {
            throw new NotImplementedException();
        }

        void ICihaz.kapat()
        {
            kapat();
        }

        public void goster(string Yazi)
        {
            throw new NotImplementedException();
        }
    }


    class LCD : ICihaz
    {
        void Ac() { Console.WriteLine("Tv Açıldı"); }
        void kapat() { Console.WriteLine("Tv kapandı"); }

        void Goster(string Yazi) { Console.WriteLine("Projektör"); }

        public void ac()
        {
            throw new NotImplementedException();
        }

        void ICihaz.kapat()
        {
            kapat();
        }

        public void goster(string Yazi)
        {
            throw new NotImplementedException();
        }
    }

    class Projektör : ICihaz
    {



        void Goster(string Yazi) { Console.WriteLine("Projektör" + Yazi); }

        public void ac()
        {
            { Console.WriteLine("Projektör  Açıldı"); }
        }

        void kapat()
        {
            Console.WriteLine("Projektör kapandı");

        }

        public void goster(string Yazi)
        {
            throw new NotImplementedException();
        }

        void ICihaz.ac()
        {
            throw new NotImplementedException();
        }

        void ICihaz.kapat()
        {
            kapat();
        }

        void ICihaz.goster(string Yazi)
        {
            throw new NotImplementedException();
        }
    }

    class YayınYap
    {
        public static void YayinYapma(ICihaz[] cihazlar)
        {
            void YayınYapma()
            {
                foreach (ICihaz c in cihazlar)
                {
                    c.ac();
                    c.goster("Test Yayını");
                    c.kapat();
                    Console.WriteLine("-------------------");

                }

            }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ICihaz[] cihazlar = { new TV(), new LCD(), new Projektör()};

            YayınYap.YayinYapma(cihazlar);
        }
    }
}
