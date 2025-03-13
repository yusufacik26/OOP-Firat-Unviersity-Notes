using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bölme_Sonucu_Kalanı_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolen = 6;
                
            int bolunen=70;

            int sonuc = bolunen / bolen;

            int kalan = bolunen % bolen;

            Console.WriteLine("bolum =" + sonuc);
            Console.WriteLine("Kalan = " + kalan);


        }
    }
}
