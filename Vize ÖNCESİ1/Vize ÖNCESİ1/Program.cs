using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vize_ÖNCESİ1
{
    class Hasta
    {
        public int no;
        public string ad;
        public Doktor doktoru;

        public Hasta(int no, string ad)
        {
            this.no = no;
            this.ad = ad;
            
        }
    }
    class Doktor
    {
        public string ad;
        public string brans;

        public List<Hasta> hastalar = new List<Hasta>();

        public void hastaEkle(Hasta hasta)
        {
            if (!hastalar.Contains(hasta))
            {
                hastalar.Add(hasta);


            }
        }
        public Doktor(string ad, string brans)
        {
            this.ad = ad;
            this.brans = brans;
            
        }
    }
    class Hastane
    {
      

        List<Doktor> doktorlar = new List<Doktor>();
        public void DoktorEkle(Doktor dr)
        {
            if (!doktorlar.Contains(dr)){

                doktorlar.Add(dr);

            }



        }
        public void hastaAta(Hasta h,string doktorAdi)
        {
            Doktor dr = null;

            foreach(Doktor doktor in doktorlar)
            {
                if (doktorAdi == doktor.ad)
                {

                    dr = doktor; 
                    dr.hastaEkle(h);
                    break;
                }

               

            }

        }


        public void TümHastalarılistele() {

            foreach(Doktor doktor in doktorlar)
            {
                Console.WriteLine($"Dr.{doktor.ad}  - Branş:{doktor.brans}");

                foreach(Hasta hastalar in doktor.hastalar)
                {
                    Console.WriteLine($"hasta Adı:{hastalar.ad} hasta Numarası:{hastalar.no}");


                }

                Console.WriteLine("\t");

            }
            
        
        
        
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Doktor d1 = new Doktor("Ayşe", "Dahiliye");
            Doktor d2 = new Doktor("Mehmet", "Kardiyoloji");

            Hasta h1 = new Hasta(101, "Ahmet");
            Hasta h2 = new Hasta(102, "Zeynep");
            Hasta h3 = new Hasta(103, "Mert");

            Hastane hst = new Hastane();
            hst.DoktorEkle(d1);
            hst.DoktorEkle(d2);

            hst.hastaAta(h1, "Ayşe");
            hst.hastaAta(h2, "Ayşe");
            hst.hastaAta(h3, "Mehmet");

            hst.TümHastalarılistele();

            Console.ReadKey();
        }
    }
}
