using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mayıs_Lab
{
    public interface IAnimasyonlar
    {
        void Yuru();
        void SagaDon();
        void SolaDon();
        void Dur();





    }

    public interface IUcusAnimasyonları
    {
        void uc();
        void yereIn();


    }

    public class UcanKaraketer : IAnimasyonlar, IUcusAnimasyonları {

        public void Yuru() { Console.WriteLine("Karakter Hızlı Yürüyor"); }
        public void SolaDon() { Console.WriteLine("Karakter Hızlı Sola Dönüyor"); }
        public void SagaDon() { Console.WriteLine("Karakter Hızlı Sağa Dönüyor"); }
        public void Dur() { Console.WriteLine("Karakter Hızlı Duruyor"); }
        public void uc() { Console.WriteLine("Karakter Uçuyor"); }
        public void yereIn() { Console.WriteLine("Karakter Yere indi"); }

    }

    public class YavasKaraker : IAnimasyonlar
    {
        
        public void Yuru() {
            int hiz = 10;
            
            Console.WriteLine("Karakter Yavaş Yürüyor Hızı "+hiz); }

        
        public void SagaDon() { }
        public void SolaDon() { }
        public void Dur() { }
    }
    

    public class HızlıKarakter : IAnimasyonlar
    {

        public void Yuru() { Console.WriteLine("Karakter Hızlı Yürüyor"); }
        public void SolaDon() { Console.WriteLine("Karakter Hızlı Sola Dönüyor"); }
        public void SagaDon() { Console.WriteLine("Karakter Hızlı Sağa Dönüyor"); }
        public void Dur() { Console.WriteLine("Karakter Hızlı Duruyor"); }


    }

    class Program
    {
        static void Main(string[] args)
        {
            YavasKaraker yk = new YavasKaraker();
            yk.Yuru();


            HızlıKarakter hk = new HızlıKarakter();
            hk.Yuru();

        }
    }
}
