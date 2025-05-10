using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mayıs_Lab3
{
    abstract class Dersler
    {

        public abstract void DersIcerikleri();
        public void TumDersleriSil()
        {
            Console.WriteLine("Tüm Dersler Silindi!!!!!");

        }




    }

    class Algoritma:Dersler
    {
        public override void DersIcerikleri() {// sınıf abstract olduğu için override ediyoruz!!!!!!
            Console.WriteLine("Algoritma dersinin bilgileri cekildi!");
        }





    }
    class Program
    {

        static void Main(string[] args)
        {
            //Soyut sınıflardan nesne oluşturmaya çalışmayın!!
            Algoritma alg = new Algoritma();

            alg.DersIcerikleri();
        }
    }
}
