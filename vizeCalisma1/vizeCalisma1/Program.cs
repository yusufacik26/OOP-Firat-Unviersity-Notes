using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeCalisma1
{

    class Siparis
    {
        public string UrunAdi;
        public int adet;
        public int fiyat;


        public override string ToString() // Bilgileri yazdırmak için önemli!!!!!!
        {
            return $"Ürün: {UrunAdi}, Adet: {adet}, Fiyat: {fiyat}₺";
        }

    }

    class masa
    {

        List<Siparis> siparisler = new List<Siparis>();

        public void siparisEkle(Siparis s)
        {

            siparisler.Add(s);


        }

        public void Listele() {
        
            foreach(Siparis s in siparisler)
            {
                Console.WriteLine(s);


            }
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            masa masa1 = new masa();

            Siparis s1 = new Siparis { UrunAdi = "Pizza", adet = 2, fiyat = 100 };
            Siparis s2 = new Siparis { UrunAdi = "Kola", adet = 1, fiyat = 20 };
            Siparis s3 = new Siparis { UrunAdi = "Kola", adet = 1, fiyat = 20 };

            masa1.siparisEkle(s1);
            masa1.siparisEkle(s2);
            masa1.siparisEkle(s3);

            masa1.Listele();
        }
    }
}
