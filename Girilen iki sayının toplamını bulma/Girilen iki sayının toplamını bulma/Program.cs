using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_iki_sayının_toplamını_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 ,sum;

            Console.WriteLine("1.Sayıyı girin:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı girin: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            sum = num1 + num2;

            Console.WriteLine("{0} + {1} ={2}", num1, num2, sum);
        
        }
    }
}
