using System;

namespace _2._2_Zadatak_18_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Unesite proizvoljan tekst - ");
            string unos = Console.ReadLine();
            
            string tekst = "";
            for (int i = unos.Length - 1; i >= 0; i--)
            {
                tekst += unos[i].ToString();
            }
            Console.WriteLine($"\nObrnuti tekst je {tekst}");
            Console.ReadKey();
        }

    }
}