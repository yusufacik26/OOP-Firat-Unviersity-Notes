using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize24._1
{
    class kisi
    {

        public int id;
        public string isim;
        public pasaport p;

        public kisi(string isim, int id)
        {
            this.isim = isim;
            this.id = id;


        }
    }

    class pasaport
    {
        public string ulkeKodu;
        public int seriNo;
        public kisi sahip;

        public pasaport(string ulkeKodu, int seriNo, kisi sahip)
        {
            this.ulkeKodu = ulkeKodu;
            this.seriNo = seriNo;
            this.sahip = sahip;

        }

    }

    class ucus
    {
        List<kisi> kisiler = new List<kisi>();

        public void ekle(kisi binici)
        {
            kisiler.Add(binici);
        }

        public void listele()
        {

            foreach(kisi k in kisiler)
            {
                Console.WriteLine(k.id + " " + k.isim+" "+k.p.ulkeKodu);

            }
    }
        class Program
        {

            static void Main(string[] args)
            {
            }
        }
    
}
