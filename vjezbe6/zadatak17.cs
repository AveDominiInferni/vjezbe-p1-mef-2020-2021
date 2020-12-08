using System;

namespace _17.Zadatak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite proizvoljan tekst");
            string unos1 = Console.ReadLine();

            for (int i = 0; i < unos1.Length; i++)
            {
                Console.Write(unos1.Substring(1 + i, 1));
                i++;
            }
            Console.ReadLine();
            Console.ReadKey();



        }
    }
}
