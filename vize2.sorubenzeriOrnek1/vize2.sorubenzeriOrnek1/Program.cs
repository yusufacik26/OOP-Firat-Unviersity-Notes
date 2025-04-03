using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vize2.sorubenzeriOrnek1
{

    class Gunler
    {
        string[] gunler = { "", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

        public int gunBul(string girdi) {
        
        for(int i  = 0; i < gunler.Length; i++)
            {
                if(girdi  == gunler[i]){
                    return i;
                }

                

            }
            return -1;
        
        }

        public int this[string girdi]
        {

            get { return gunBul(girdi); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Gunler g = new Gunler();
             Console.WriteLine(g["Çarşamba"]);  // Çıktı: 3
        }
    }
}
