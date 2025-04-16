using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul___Öğretmen___Sınıf_İlişkisi
{
    class ogretmen
    {
        public string isim;
        public string brans;

        public ogretmen(string isim, string brans)
        {
            this.isim = isim;
            this.brans = brans;
        }
    }

    class sınıf
    {
        public string ad;
        public ogretmen ogretmeni;
        public List<ogrenci> ogrenciler = new List<ogrenci>();

        public sınıf(string ad, ogretmen ogretmeni)
        {
            this.ad = ad;
            this.ogretmeni = ogretmeni;

        }


    }
    class ogrenci
    {
        public string ad;
        public int no;

        public ogrenci(string adi, int no)
        {
            this.ad = adi;
            this.no = no;

        }


    }

    class okul
    {
        public List<sınıf> sınıflar = new List<sınıf>();
        public void SınıfEkle(sınıf s)
        {
            if (!sınıflar.Contains(s))
            {
                sınıflar.Add(s);
            }


        }



        public void OgrenciEkle(ogrenci o, string sinifAdi)
        {
            foreach (sınıf snf in sınıflar)
            {
                if (snf.ad == sinifAdi)
                {
                    snf.ogrenciler.Add(o);

                }


            }



        }
        public void TumSiniflariListele()
        {
            foreach(sınıf s in sınıflar)
            {
                Console.WriteLine($"sınıf adı:{s.ad} sınıf ögretmeni{s.ogretmeni.isim}");


                foreach(ogrenci o in s.ogrenciler)
                {

                    Console.WriteLine($"{o.ad} {o.no}");

                }

                Console.WriteLine("\t");
            }


        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            ogretmen ogretmen1 = new ogretmen("Ayşe Öğretmen", "Matematik");
            ogretmen ogretmen2 = new ogretmen("Mehmet Öğretmen", "Fen Bilgisi");

            // Sınıflar
            sınıf sinif1 = new sınıf("9A", ogretmen1);
            sınıf sinif2 = new sınıf("9B", ogretmen2);

            // Okul nesnesi
            okul okul = new okul();

            // Sınıfları ekle
            okul.SınıfEkle(sinif1);
            okul.SınıfEkle(sinif2);

            // Öğrenciler
            ogrenci o1 = new ogrenci("Yusuf", 1);
            ogrenci o2 = new ogrenci("Emir", 2);
            ogrenci o3 = new ogrenci("Musa", 3);

            // Öğrencileri sınıflara ata
            okul.OgrenciEkle(o1, "9A");
            okul.OgrenciEkle(o2, "9A");
            okul.OgrenciEkle(o3, "9B");

            // Listele
            okul.TumSiniflariListele();


        }
    }
    }
