using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9mayıs_Teori
{
    class mudur :kisi, Icalisabilen
    {
        
       public string calis()
        {
            return "Naber Müdür!!";
        }

        public override string bilgiGoster(string isim)
        {
            return base.isim;


        }


    }

}
