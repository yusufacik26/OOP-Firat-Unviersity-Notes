using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_propery
{
    class Urun
    {
        public string barkodNo;
        public int uretimYili;
        public int UretimYili
        {

            get { return uretimYili; }
        }

        private string rafOmru;

        public string RafOmru
        {
            get {
                string uretimyıl = Convert.ToString(2024 - UretimYili);

                if (uretimyıl.Equals('0')) { return "-1"; }
                else { return uretimyıl; }


            }
                
                

        }
        public string BarkodNo
        {

            get { return barkodNo; }
            set
            {
                int ciftler = 0;
                int tekler = 0;

                string girilen = value;
                int toplam = 0;
                for (int i = 0; i < 12; i++)
                {
                    int rakam = girilen[i] - '0';

                    if ((i + 1) % 2 == 0) // Çift sıra (2., 4., ...)
                         += rakam * 3;
                    else // Tek sıra (1., 3., ...)
                        toplam += rakam;
                }

                int kontrolHane = (10 - (toplam % 10)) % 10;

                if (kontrolHane == (girilen[12] - '0')&&girilen.Length==13)
                {
                    barkodNo = girilen;
                }


            }
        }





    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
