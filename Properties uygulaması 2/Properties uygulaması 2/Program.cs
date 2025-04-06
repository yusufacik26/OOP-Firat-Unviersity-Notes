using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_uygulaması_2
{
    class set_get
    {

        int sayi;
        
        public int SahteOzellik
        {

            get
            {
                if (sayi > 100) return sayi / 100;
                else
                {   
                    return sayi;

                }
            }

            set { if (value < 0) {

                    sayi = 0;
                }

                else
                {
                    sayi = value;

                }
            
            
            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            set_get nesne = new set_get();

            nesne.SahteOzellik = 110;

            Console.WriteLine(nesne.SahteOzellik);
        }
    }
}
