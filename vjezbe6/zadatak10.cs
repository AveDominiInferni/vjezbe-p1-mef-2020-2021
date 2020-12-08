using System;

namespace vjezbe6
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int[] niz = { 10, 5, 6, -3, 2, 12, 0, -2, 16 };
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == 12)
                {
                    Console.WriteLine("Broj 12 se nalazi na indexu " + i);
                    return;
                }
            }
            Console.WriteLine("Broj 12 se ne nalazi u nizu");
        }
    }
}