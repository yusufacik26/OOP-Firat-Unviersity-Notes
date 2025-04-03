using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize24._4
{

    class Calisan
    {
        private string tcNo;
        public int baslamaYili;

        public int CalismaYili(int baslamaYili)
        {
            int hesap = 2024 - baslamaYili;

            if(hesap>0) { return hesap; }
            else
            {
                return -1;
            }}

        public string TcNo {
        
        get { return tcNo; }
            set
            {

                int tekToplam = 0;
                int ciftToplam = 0;

                string gelen = value;

                for(int i = 0; i < 9; i++)
                {
                    if (i % 2 == 0) { ciftToplam += (gelen[i] - '0'); }
                    else
                    {
                        tekToplam += (gelen[i] - '0');

                    }

                }
                int genelToplam = tekToplam + ciftToplam + (gelen[9] - '0');


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
