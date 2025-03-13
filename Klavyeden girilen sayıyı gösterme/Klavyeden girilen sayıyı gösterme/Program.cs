using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_sayıyı_gösterme
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number;
             Console.Write("Bir sayı girin");
             number = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Girilen sayi :{0}", number);

             Konsolda Girilen Sayıyı gösteren kod bloğu

             */

            // Konsola Girilen 2 sayıyı çarpan ve bu değerleri gösteren kod

            float num1, num2, result;

            Console.WriteLine("Sayı 1 giriniz:");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Sayı 2 giriniz:");
            num2 = Convert.ToSingle(Console.ReadLine());

            result = num1 * num2;

            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

            //C# dilinde Convert.ToSingle yöntemi, girdiği değeri single precision floating-point number
            //(tek duyarlıklı kayan nokta sayısı) olan float türüne dönüştürür.
        }
    }
}
