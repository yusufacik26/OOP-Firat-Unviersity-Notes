using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Ornek1
{
    class Program
    {
        enum bolumler {Yazılım_Muh_,Elektrik_elektronik_Müh_,Mekatronik_Müh_,Bilgisayar_Müh_,Makine_Müh_ }
        static void Main(string[] args)
        {
            bolumler b;

            for (b = bolumler.Yazılım_Muh_; b <= bolumler.Makine_Müh_; b++)
            {
                Console.WriteLine("{0}'ın etiketi={1,4:d}", b, (int)b);

            }
        }
    }
}
