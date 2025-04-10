using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_TC_sorusu
{
    class Calisan
    {
        private string tcNo;
        public int baslamaYili;

        public int calismaYili {

            get { if(baslamaYili > 0)
                {
                    return 2024 - baslamaYili;

                }
                else
                {
                    return -1;
                }
            }
        }

        public string TcNo
        {
            get { return tcNo; }

            set
            {
                string gelen = value;
                int tekler = 0;
                int ciftler = 0;

                for(int i = 0; i < 9; i++)
                {
                    if (i % 2 ==) { ciftler += tcNo[i] - '0'; }
                    else { ciftler += tcNo[i] - '0'; }


                }

                int tumToplam = tekler + ciftler + (tcNo[9] - '0');

                if (gelen[0]!='0' && ((tekler * 7) - ciftler)%10 == gelen[9]-'0')&& tumToplam== gelen[10]-'0'){


                    tcNo = value;
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
