using System;

namespace _24.Zadatak
{
    class Program
    {
        static void Main()
        {
            string[] niz = new string[] { "Kompjuterske", "simulacije", "nekih", "vremenski", "ovisnih", "problema", "inzinjerske", "fizike" };
            string tekst = "";
            for (int i = 0; i < niz.Length; i++)
            {
                if (i == niz.Length - 2)
                    tekst = tekst + niz[i] + "";


                else if (i != niz.Length - 1)
                tekst = tekst + niz[i] + " ";


                else 
                {
                    tekst = tekst + ".";
                }
            }
            Console.WriteLine(tekst);



        }
    }
}
