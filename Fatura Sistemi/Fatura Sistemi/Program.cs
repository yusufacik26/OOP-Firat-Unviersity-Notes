using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura_Sistemi
{
    class Urun
    {
        public string ad;
        public double BirimFiyat;

        public Urun(string Ad, double birimFiyat)
        {
            this.ad = Ad;
            this.BirimFiyat = birimFiyat;
        }
    }

    class FaturaKalemi
    {

        public Urun urun;
        public int Adet;

        public FaturaKalemi(Urun urun, int adet)
        {
            this.urun = urun;
            this.Adet = adet;
        }

        public override string ToString()
        {
            return $"Ürün: {urun.ad}, Adet: {Adet}, Fiyat: {urun.BirimFiyat}₺";
        }
    }
    class Fatura
    {
        List<FaturaKalemi> Kalemler = new List<FaturaKalemi>();

        public void KalemEkle(FaturaKalemi kalem)
        {
            Kalemler.Add(kalem);

        }

        public double ToplamTutar()
        {
            double top = 0;



            foreach (FaturaKalemi k in Kalemler)
            {

                top += k.urun.BirimFiyat * k.Adet;
            }

            return top;


        }

        public void Listele()
        {
            Console.WriteLine("Fatura Kalemleri:");
            foreach (FaturaKalemi f in Kalemler)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine($"Toplam Tutar: {ToplamTutar()}₺");




        }


        class Program
        {
            static void Main(string[] args)
            {

                Urun urun1 = new Urun("Kalem", 10);
                Urun urun2 = new Urun("Defter", 25);

                FaturaKalemi kalem1 = new FaturaKalemi(urun1, 3);
                FaturaKalemi kalem2 = new FaturaKalemi(urun2, 2);

                Fatura fatura = new Fatura();
                fatura.KalemEkle(kalem1);
                fatura.KalemEkle(kalem2);

                fatura.Listele();

            }
        }
    }
}
