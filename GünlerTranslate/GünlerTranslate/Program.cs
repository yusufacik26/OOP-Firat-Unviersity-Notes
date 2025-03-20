using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GünlerTranslate
{

    class gunler {

        Dictionary<string, string> days = new Dictionary<string, string>()
        {
        { "Monday", "Pazartesi" },
        { "Tuesday", "Salı" },
        { "Wednesday", "Çarşamba" },
        { "Thursday", "Perşembe" },
        { "Friday", "Cuma" },
        { "Saturday", "Cumartesi" },
        { "Sunday", "Pazar" }

        };
    
        public string this[string gun]{


            get{
            
            
                return days.ContainsKey(gun) ? days[gun] : "geçersiz gun";


            }
            
            
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            gunler gunler = new gunler();

            Console.WriteLine("Bir gün giriniz ingilizcesini");

            string aDay = Console.ReadLine();

            Console.WriteLine(gunler[aDay]);
        }
    }
}
