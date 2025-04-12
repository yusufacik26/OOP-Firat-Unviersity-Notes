using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_indexleme_çalışması
{
    class uye
    {
        private string[] Uyeler = { "yusuf", "emir", "musa", "semra" };

        public string this[int index]
        {
            get
            {
                if(index<0 || index >= Uyeler.Length)
                {
                    return null;

                }
                else
                {
                    return Uyeler[index];

                }
            }
            set {if(index>=0 && index <= Uyeler.Length)
                {
                    Uyeler[index] = value;

                } }

        }
        public int this[string aranan]
        {

            get
            {
                for(int i = 0; i < Uyeler.Length; i++)
                {
                    if (aranan.Equals(Uyeler[i]))
                    {

                        return i;
                    }


                }
                return -1;

            }
        


        }
        public int uzunluk
        {

            get { return Uyeler.Length; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            uye u = new uye();

            Console.WriteLine(u[0]);
            u[0] = "Ali";
            for (int i = 0; i < u.uzunluk; i++)
                Console.WriteLine(u[i]);
            if (u["semra"] >= 0)
            {
                Console.WriteLine("Aranan dizide var:{0}", u["semra"]);

            }
            else Console.WriteLine("Aranan dizide yok");

        }
    }
}
