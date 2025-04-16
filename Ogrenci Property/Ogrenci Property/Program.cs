using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Property
{
    class ogrenci
    {
        private string ogrenciNum;
        public int girisYili;
        private string sinifSeviyesi;
        public string SinifSeviyesi {

            get { 
                if ((2024 - girisYili) > 4) { return "mezun"; }
                else { return Convert.ToString(2024 - girisYili); }
            
            }

        }

        public string OgrenciNum
        {
            get { return ogrenciNum; }
            set
            {
                string girilen = value;

                if(girilen.Length==9 && girilen[0]=='1'&& girilen[1]=='0'&& girilen[2] == '1')
                {
                    ogrenciNum = value;

                }


            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci o1 = new ogrenci();
            o1.OgrenciNum = "101234567";
            o1.girisYili = 2021;

            Console.WriteLine("Öğrenci No: " + o1.OgrenciNum);
            Console.WriteLine("Sınıf Seviyesi: " + o1.SinifSeviyesi);

            ogrenci o2 = new ogrenci();
            o2.OgrenciNum = "999123456"; // Geçersiz, set edilmez
            o2.girisYili = 2017;

            Console.WriteLine("Öğrenci No: " + o2.OgrenciNum); // null döner
            Console.WriteLine("Sınıf Seviyesi: " + o2.SinifSeviyesi); // mezun
        }
    }
}
