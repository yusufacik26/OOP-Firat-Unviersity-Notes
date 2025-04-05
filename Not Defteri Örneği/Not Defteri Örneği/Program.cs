using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Defteri_Örneği
{
    class notDefter
    {
        private Dictionary<string, int> notlar = new Dictionary<string, int>()
    {
        { "Ayşe", 85 },
        { "Fatma", 90 }
    };

        public int this[string isim]
        {
            get
            {
                if (notlar.ContainsKey(isim)){
                    return notlar[isim];
                }
                return -1;
            }

            set { notlar[isim] = value; }

        }
        public string this[int index]
        {
            get { if (notlar[index] == index) {

                    return notlar[index];
                
                } }

        }




    }
        class Program
    {
        static void Main(string[] args)
        {
            notDefter nots = new notDefter();

            Console.WriteLine(nots+nots["Ayşe"]);
        }
    }
}
