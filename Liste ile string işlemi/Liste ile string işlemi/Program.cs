using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_ile_string_işlemi
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> noktalama = new List<char>{ '.', ',', ';', '%', '#', '*', '?', '!','+','-' };

            Console.WriteLine("Hacı içinde noktalama ve özel karakter içeren bir cümle yaz!!");

            string cumle = Console.ReadLine();

            string yeniCumle = "";

            for(int i = 0; i < cumle.Length; i++)
            {
                if (!(noktalama.Contains(cumle[i]))) {

                    yeniCumle += cumle[i];
                
                }


            }

            Console.WriteLine(yeniCumle);

        }
    }
}
