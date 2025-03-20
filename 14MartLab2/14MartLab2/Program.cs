using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _14MartLab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Int64 x;
            String line;
            try {// yazma kısmı 
                StreamWriter sw = new StreamWriter("C:\\Users\\yusuf\\Desktop\\Yeni klasör\\Text.txt");
                
                for (x = 0; x < 10; x++) {

                    sw.Write(x+"\n");
                
                }
                sw.Close();

                StreamReader sr = new StreamReader("C:\\Users\\yusuf\\Desktop\\Yeni klasör\\Text.txt");
                line = sr.ReadLine();

                while(line != null) {

                    Console.WriteLine(line);
                    line = sr.ReadLine();// her seferinde yeni satıra geçmesini sağlar
                }
                sr.Close();
            }
            catch(Exception e) { }
        }
    }
}
