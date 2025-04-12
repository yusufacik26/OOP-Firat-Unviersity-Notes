using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Ödev
{
    using System;

    public class MyArrayList
    {
        private object[] items;
        private int count;

        // Başlangıç kapasitesi
        private const int DefaultCapacity = 4;

        // Constructor
        public MyArrayList()
        {
            items = new object[DefaultCapacity];
            count = 0;
        }

        // Öğelerin sayısı (Count özelliği)
        public int Count
        {
            get { return count; }
        }

        // Belirtilen indeksdeki öğeyi döndürür
        public object Get(int index)
        {
            CheckIndex(index);
            return items[index];
        }

        // Yeni bir öğe sona eklenir
        public void Add(object item)
        {
            EnsureCapacity();
            items[count] = item;
            count++;
        }

        // Belirtilen indekse bir öğe eklenir
        public void Insert(int index, object item)
        {
            if (index < 0 || index > count)
                throw new ArgumentOutOfRangeException(nameof(index), "Geçersiz indeks.");

            EnsureCapacity();

            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
            count++;
        }

        // Belirtilen indeksdeki öğe kaldırılır
        public void RemoveAt(int index)
        {
            CheckIndex(index);

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[count - 1] = null; // Son öğeyi temizle
            count--;
        }

        // Listedeki öğeleri virgül ile ayrılmış biçimde döndürür javadaki split gibi
        public override string ToString()
        {
            string[] stringItems = new string[count];

            for (int i = 0; i < count; i++)
            {
                stringItems[i] = items[i]?.ToString();
            }

            return string.Join(", ", stringItems);
        }

        // Kapasiteyi kontrol eder kapasiteyi 2 katına da çıkartma işlemi yapabilir
        private void EnsureCapacity()
        {
            if (count >= items.Length)
            {
                int newCapacity = items.Length * 2;
                object[] newItems = new object[newCapacity];
                Array.Copy(items, newItems, items.Length);
                items = newItems;
            }
        }

        // Geçerli indeks mi diye kontrol eder
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index), "Geçersiz indeks.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();

            list.Add("Elma");
            list.Add("Armut");
            list.Add(42);
            list.Insert(1, "Muz");

            Console.WriteLine("Liste: " + list.ToString()); 
            Console.WriteLine("2. indeks: " + list.Get(2)); 

            list.RemoveAt(0);
            Console.WriteLine("Silindikten sonra: " + list.ToString()); 
            Console.WriteLine("Eleman sayısı: " + list.Count); 
        }
    }
}
