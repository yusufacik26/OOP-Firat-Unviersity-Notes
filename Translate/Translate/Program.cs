using System;

class Sayilar
{
    string[] sayilar = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < sayilar.Length)
                return sayilar[index];
            else
                return "Invalid Number";
        }
    }
}

class Program
{
    static void Main()
    {
        Sayilar sayi = new Sayilar();
        Console.Write("Bir rakam gir (0-9): ");
        int girdi = int.Parse(Console.ReadLine());

        Console.WriteLine("İngilizce: " + sayi[girdi]);
    }
}
