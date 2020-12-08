using System;

namespace _23.Zadatak
{
    class Program
    {
        static void Main()
        {
            string[] niz = new string[] { "Kompjuterske", "simulacije", "nekih", "vremenski", "ovisnih", "problema", "inzinjerske", "fizike" };
            string tekst = "";
            for (int i = 0; i < niz.Length; i++)
            {
                tekst = tekst + niz[i] + " ";
            }
            Console.WriteLine(tekst);
            
        }



    }


}