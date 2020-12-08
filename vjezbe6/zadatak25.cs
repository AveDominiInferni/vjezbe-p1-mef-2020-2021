using System;

namespace _25.Zadatak
{
    class Program
    {
        static void Main()
        {
            string tekst = "Kompjuterske simulacije nekih vremenski ovisnih problema inzinjerske fizike";
            string[] niz = tekst.Split(" ");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }
            Console.ReadLine();



        }

    }
}
