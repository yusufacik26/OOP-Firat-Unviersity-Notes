using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_Uygulamaları
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("One");
            list.Add("two");

            for (int i = 0; i < list.Count; i++) {

                Console.WriteLine(list[i]);
            }
            /* Count == dizinin boyutunu verir
             * sort clear gibi metodlar normal dizilerdeki gibi aynı işlevi görür
             *
             *!!! Convert metodu dönüşüm yapılmasını sağlar
        
            */
            
            }
    }
}
