using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static günler_Enum.Program;

namespace günler_Enum
{
    class Program
    {
        public enum Gun {pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar }
        public static Gun GunOtele(Gun g, int kacGunSonra)
        {
            return (Gun)(((int)g + kacGunSonra) % 7);
        }
        static void Main(string[] args)
        {
            Gun bugun = Gun.carsamba;
            Gun sonra = GunOtele(bugun, 3);
            Console.WriteLine("3 gün sonra: " + sonra); // Cumartesi
        }
    }
}
