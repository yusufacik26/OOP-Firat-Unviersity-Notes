using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CümledekiÖzelKarakterleriKaldıranUyguama
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] karakter = { '*', '-', '$', '#', ')', '(', '/', '%', '+', '!' };


            Console.WriteLine("Bir cümle girinz");

            string cumle = Console.ReadLine();
            string yeniCumle = "";
           

            foreach(char k in cumle)
            {

                if (!(karakter.Contains(k))) {

                    yeniCumle += k;
                }

                


            }
            Console.WriteLine("Cümlenin temizlenmiş hali"+yeniCumle);



        }
    }
}
