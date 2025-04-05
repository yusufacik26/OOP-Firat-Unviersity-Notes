using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_indexleme
{
    class Kutuphane
    {
        private string[] kitaplar = { "1984", "Suç ve Ceza", "Sefiller" };


        public string this[int index]
        {

            get
            {
                if (index < 0 || index >= kitaplar.Length)
                {
                    return "Bilinmeyen kitap";


                }


                return kitaplar[index];


            }
            set
            {
                if (index >= 0 && index < kitaplar.Length)
                    kitaplar[index] = value;
            }
        }
        public int this[string kitapAdi]
        {
            get
            {
                for (int i = 0; i < kitaplar.Length; i++)
                {
                    if (kitaplar[i] == kitapAdi)
                        return i;
                }
                return -1;
            }
        }
        public int Uzunluk => kitaplar.Length;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane k = new Kutuphane();
            Console.WriteLine(k[1]); // Sefiller
            Console.WriteLine(k["Suç ve Ceza"]); // 2
            k[0] = "Game of thrones";
            Console.WriteLine(k[0]); // GOT
        }
    }
}

