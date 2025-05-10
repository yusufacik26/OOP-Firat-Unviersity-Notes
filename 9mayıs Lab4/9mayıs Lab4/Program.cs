using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9mayıs_Lab4
{

    abstract class Arac {

        public string marka { get; set; }
        public string model { get; set; }
        public string yil { get; set; }


        public abstract void Kirala();
        public abstract void IadeEt();
        
        public void BilgiYazdir()
        {
            Console.WriteLine($"Araç:{marka}, Model:{model}, Yılı:{yil}");



        }
    }
    class otomobil : Arac
    {

        public override void Kirala()
        {
            Console.WriteLine(marka,model,"Otomobil kiralandı");



        }

        public override void IadeEt()
        {
            Console.WriteLine(marka, model, "Otomobil iade edildi!!!");



        }

        


    }

    class motosiklet : Arac
    {

        public override void Kirala()
        {
            Console.WriteLine(marka, model, "Motosiklet kiralandı");



        }

        public override void IadeEt()
        {
            Console.WriteLine(marka, model, "Motosiklet iade edildi!!!");



        }




    }

    class KiralamaIslemleri
    {

        public static void KiralamaYap(Arac arac) {

            arac.BilgiYazdir();
            arac.Kirala();
            arac.IadeEt();
            Console.WriteLine("-----------------");
        
        
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Arac otomobil = new otomobil { marka = "toyota", model = "corolla",yil =  "123" };
            Arac otomobil2 = new otomobil { marka = "ford", model = "mustang", yil = "1969" };
            Arac motosiklet = new motosiklet { marka = "Yamaha", model = "Ybr125", yil = "2015" };



            KiralamaIslemleri.KiralamaYap(otomobil);
            KiralamaIslemleri.KiralamaYap(otomobil2);
            KiralamaIslemleri.KiralamaYap(motosiklet);


        }
    }
}
