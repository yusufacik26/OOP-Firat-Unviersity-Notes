using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_b_işlemini_bulma1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int sonuc = 1;
            

            Console.WriteLine("Tabanı girin :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üssü girin:");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num2; i++) {

                sonuc *= num1 ;
            
            }

            Console.WriteLine("{0}^{1} = {2}", num1, num2, sonuc);

        }
    }
}
