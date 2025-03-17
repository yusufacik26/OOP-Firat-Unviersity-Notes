using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dosya_İşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\yusuf\\Desktop\\Yeni klasör\\file.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            fs.Close();
            string line;

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("merhaba");
                writer.Write("coni");
                writer.Write("yazma işlemi başarılı");

            }

            using (StreamReader reader = new StreamReader(path)) {

                line = reader.ReadToEnd();
            }
            Console.WriteLine(line);
               

            
            
            
            
            }
              


        }
    }

