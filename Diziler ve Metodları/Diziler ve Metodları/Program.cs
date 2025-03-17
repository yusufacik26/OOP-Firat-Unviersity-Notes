using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Diziler_ve_Metodları
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] dizi = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine(dizi.GetLength(0));

            Console.WriteLine(dizi.GetLength(1)); // Bu sütun kısmını verir

            for (int i = 0; i < dizi.GetLength(0); i++) {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {

                    Console.WriteLine(dizi[i, j]);
                }
                
            }

            // Bu kısımda dizinin boyutunu düzenlediğimiz metodları kullandık
            string[] iller = new string[2];
            iller[0] = "Eskişehir";
            iller[1] = "Ankara";

            Array.Resize(ref iller, 3);
            iller[2] = "Istanbul";


            // dizi kopyalama kısmı CopyTo() metodu


            string[] sevdiğim_sehirler = new string[7];

            if (iller.Length + 1 <= sevdiğim_sehirler.Length)
            {
                iller.CopyTo(sevdiğim_sehirler, 0);
            }
            else
            {
                Console.WriteLine("Kopyalama işlemi başarısız: Hedef dizi yeterli boyutta değil.");
            }


            Console.WriteLine(sevdiğim_sehirler[0]);


            Console.WriteLine();
            //Copy() metodu ile dizi kopyalama işlemi

            int[] sayilar = new int[] { 1, 2, 3, 4, 5 };

            int[] sayilar2 = new int[5];
            Array.Copy(sayilar, sayilar2, 5);

            foreach (int i in sayilar2) {
                Console.WriteLine(i);
            }


            // Array.Sort() metodu ile dizi sıralama işlemi

            Array Dizi = Array.CreateInstance(typeof(string), 5);
            Dizi.SetValue("Eskişehir", 0);
            Dizi.SetValue("Ankara", 1);
            Dizi.SetValue("Istanbul", 2);

            Array.Sort(Dizi);
            foreach (string i in Dizi)
            {
                Console.WriteLine(i);
            } Console.WriteLine();

















            }






    }
}
