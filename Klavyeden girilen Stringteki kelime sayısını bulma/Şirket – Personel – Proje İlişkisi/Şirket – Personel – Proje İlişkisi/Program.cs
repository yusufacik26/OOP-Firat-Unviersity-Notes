using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket___Personel___Proje_İlişkisi
{
    class sirket
    {


    }
    class Personel{

        public int sicilNo;
        public string ad;
        public string unvan;

        public Personel(int sicilNo,String ad, string unvan)
        {
            this.ad = ad;
            this.unvan = unvan;
            this.sicilNo = sicilNo;



        }
        


        
    }

    class Proje
    {
        public string projeAdi;
        public Personel sorumlu;

        public Proje(string projeAdi,Personel personel) {


            this.projeAdi = projeAdi;
            this.sorumlu = personel;
        }


    }

    class Sirket {

        List<Proje> projeler = new List<Proje>();

        public void ProjeEkle(Proje p)
        {

            if (!projeler.Contains(p))
            {
                projeler.Add(p);


            }


        }

        public void SorumluDegistir(string projeAdi, Personel yeniSorumlu) {
        
            foreach(Proje p in projeler)
            {
                if (projeAdi == p.projeAdi)
                {
                    p.sorumlu = yeniSorumlu;

                }


            }

        

        
        }

        public void TumProjeleriListele()
        {
            foreach(Proje p in projeler)
            {
                Console.WriteLine($"Proje adı {p.projeAdi} proje sorumlusu :{p.sorumlu.ad}");


            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Personel
            Personel p1 = new Personel(101, "Ali", "Yazılım Mühendisi");
            Personel p2 = new Personel(102, "Ayşe", "Proje Yöneticisi");

            // Projeler
            Proje proje1 = new Proje("Web Uygulaması", p1);
            Proje proje2 = new Proje("Mobil Uygulama", p2);

            // Şirket
            Sirket sirket = new Sirket();

            // Projeleri ekle
            sirket.ProjeEkle(proje1);
            sirket.ProjeEkle(proje2);

            // Proje sorumlusunu değiştir
            Personel p3 = new Personel(103, "Mehmet", "Teknik Direktör");
            sirket.SorumluDegistir("Web Uygulaması", p3);

            // Tüm projeleri listele
            sirket.TumProjeleriListele();
        }
    }
}
