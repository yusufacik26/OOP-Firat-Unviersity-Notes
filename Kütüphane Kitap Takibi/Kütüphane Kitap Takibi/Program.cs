using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Kitap_Takibi
{

    class Kitap
    {

        public string ad;
        public string yazar;
        public string ISBN;

        public Kitap(string ad, string yazar, string ıSBN)
        {
            this.ad = ad;
            this.yazar = yazar;
            this.ISBN = ıSBN;
        }

        public override string ToString()
        {
            return $"Kitap Adı:{ad},Yazar:{yazar},ISBN:{ISBN}";
           
        }
    }

    class Uye
    {
        public string adSoyad;
        List<Kitap> OduncKitaplar = new List<Kitap>();

        public Uye(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }
        public void Ekle(Kitap k)
        {

            OduncKitaplar.Add(k);

        }

        public override string ToString()
        {
            return $"{adSoyad}";
            
        }

        public void Listele()
        {
            Console.WriteLine($"\n{adSoyad} adlı üyenin ödünç aldığı kitaplar:");
            foreach (Kitap k in OduncKitaplar)
            {
                Console.WriteLine(k);
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Kitaplar
            Kitap k1 = new Kitap("1984", "George Orwell", "123456");
            Kitap k2 = new Kitap("Kürk Mantolu Madonna", "Sabahattin Ali", "789101");

            // Üye
            Uye u1 = new Uye("Zeynep Demir");

            // Kitap ekleme
            u1.Ekle(k1);
            u1.Ekle(k2);

            // Listeleme
            u1.Listele();

            Console.ReadLine();
        }
    }
}
