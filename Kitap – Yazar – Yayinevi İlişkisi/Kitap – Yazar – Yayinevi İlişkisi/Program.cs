using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap___Yazar___Yayinevi_İlişkisi
{
    class Yazar
    {
        public string ad;
        public string ulke;
        
        public Yazar(string ad,string ulke)
        {
            this.ad = ad;
            this.ulke = ulke;

        }
    }
    class Kitap
    {
        public string isim;
        public Yazar yazar;
        public int sayfaSayisi;

        public Kitap(string isim,  int sayfaSayisi,Yazar yazar)
        {
            this.isim = isim;
            this.yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
        }
    }


    class Yayinevi
    {
        List<Kitap> kitaplar = new List<Kitap>();
        private string yayıneviAdi;
        public Yayinevi(string yayıneviAdi)
        { 
            this.yayıneviAdi = yayıneviAdi;
        }

        public void KitapEkle(Kitap k){

            if (!kitaplar.Contains(k))
            {
                kitaplar.Add(k);


            }
        
        }

        public void KitaplariListele()
        {
            foreach(Kitap k in kitaplar)
            {
                Console.WriteLine($"Kitap Adı:{k.isim} Kitap yazarı:{k.yazar.ad} Kitap sayfa sayısı{k.sayfaSayisi}");

            }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            // Yazarlar
            Yazar yazar1 = new Yazar("Orhan Pamuk", "Türkiye");
            Yazar yazar2 = new Yazar("George Orwell", "İngiltere");

            // Kitaplar
            Kitap kitap1 = new Kitap("Kürk Mantolu Madonna", 350, yazar1);
            Kitap kitap2 = new Kitap("1984", 328, yazar2);
            Kitap kitap3 = new Kitap("Kürk Mantolu Madonna", 350, yazar1); // Aynı isimde kitap

            // Yayinevi
            Yayinevi yayinevi = new Yayinevi("İkonik Yayınevi");

            // Kitapları ekle
            yayinevi.KitapEkle(kitap1);
            yayinevi.KitapEkle(kitap2);
            yayinevi.KitapEkle(kitap3); // Aynı isimde kitap tekrar eklenmemeli

            // Kitapları listele
            yayinevi.KitaplariListele();
        }
    }
}
