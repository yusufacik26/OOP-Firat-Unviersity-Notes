using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çıkmış_Sınav_Sorusu
{

    class Bolum
    {
        private string isim;
        private double alan;

        public string Isim
        {

            get { return isim; }
            set { value = isim; }
        }
        public double Alan
        {
            get { return alan; }
            set { value = alan; }

        }

        public Bolum(string isim, double alan)
        {
            this.isim = isim;
            Alan = alan;
            
        }
    }
    class Konut
    {
        private int daireno;
        private int blokNo;

        public Site site;

        List<Bolum> ozelBolumler = new List<Bolum>();

        public Konut(int daireno,Site site,int blokNo)
        {
            this.daireno = daireno;
            this.site = site;
            this.blokNo = blokNo;
}
            
        public void ozelBolumEkle(Bolum eklenecekBolum)
        {
            ozelBolumler.Add(eklenecekBolum);


        }

        public double getAlan() {

            double alan = 0;

            foreach(Bolum bolum in ozelBolumler)
            {
                alan += bolum.Alan;



            }
            return alan;
        }

        public double GetBrutAlan()
        {
            double netAlan = getAlan();
            double ortakAlan = site.getOrtakAlan();
            int daireSayisi = site.daireSayisi;
            return netAlan + (ortakAlan / daireSayisi);
       }
    

}
class Site
    {
        private string isim;
        private int dairesayisi;
        List<Bolum> ortakBolumler = new List<Bolum>();
        public int daireSayisi
        {

            get { return dairesayisi; }
            set { value = dairesayisi; }

        }

        public Site(int dairesayisi, string isim)
        {
            this.dairesayisi = dairesayisi;
            this.isim = isim;
        }

        public void OrtakAlanEkle(Bolum eklenecekAlan)
        {
            ortakBolumler.Add(eklenecekAlan);


        }

        public double getOrtakAlan()
        {
            double ortakAlanSayısı = 0;

            foreach(Bolum bolum in ortakBolumler)
            {
                ortakAlanSayısı +=bolum.Alan;

            }
            return ortakAlanSayısı;
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
