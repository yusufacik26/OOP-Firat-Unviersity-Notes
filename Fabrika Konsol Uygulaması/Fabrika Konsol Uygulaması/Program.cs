using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_Konsol_Uygulaması
{
    class fabrika {

        List<isci> elemanlar = new List<isci>();

        public void ElemanEkle(isci i) {

            elemanlar.Add(i);
        
        }

        public List<isci> CalisanlariListele()
        {
            return elemanlar;

        }
    
    }
    class isci { 
    
        public int sirketKimlikNo
        {

            get;
            set;
        }

        public double Maas
        {
            get;
            set;

        }

        public TCkimlik kimlik
        {
            get;
            set;
        }


    }

    class TCkimlik {
    public int TCNo
        {
            get;
            set;

        }
    public string ad
        {
            get;
            set;

        }       
    public string soyad
        {
            get;
            set;


        }   
        public string AdSoyad
        {

            get { string adsoyad = (this.ad + " " + this.soyad).ToUpper();

                return adsoyad;
            
            }
            

        }

        public string dogumYeri
        {

            get;
            set;
        }

        public int dogumTarihi
        {

            get;
            set;
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
