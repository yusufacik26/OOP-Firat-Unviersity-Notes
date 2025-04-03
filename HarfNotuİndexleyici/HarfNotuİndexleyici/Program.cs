using HarfNotuİndexleyici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfNotuİndexleyici
{
    class Notlar
    {

        Dictionary<string, double> not = new Dictionary<string, double>{
        { "AA", 4.0 },
        { "BA", 3.5 },
        { "BB", 3.0 },
        { "CB", 2.5 },
        { "CC", 2.0 },
        { "DC", 1.5 },
        { "DD", 1.0 },
        { "FF", 0.0 }
    };

        public double this[string harf] {
         get => not.ContainsKey(harf) ? not[harf] : -1; }
        }

    }
    class Program
    {
        static void Main(string[] args)
    {
        Notlar h = new Notlar();
      Console.WriteLine(h["BA"]);  // Çıktı: 3.5
    }
}
