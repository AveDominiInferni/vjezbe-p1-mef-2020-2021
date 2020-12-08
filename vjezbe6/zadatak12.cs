using System;
using System.Collections.Generic;

namespace vjezbe6
{ 
    class zadatak
    {
        static void IspisNizova(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] niz = new int[100];
            for (int i = 0; i < niz.Length; i++)
                niz[i] = rnd.Next(-100, 101);
            int neki_broj = 69;
            Console.WriteLine("Elementi niza:");
            IspisNizova(niz);
            List<int> indexi = new List<int>();
            for (int i = 0; i < niz.Length; i++)
                if (niz[i] == neki_broj)
                    indexi.Add(i);
            if (indexi.Count > 0)
            {
                Console.WriteLine("\nBroj {0} se nalazi na indexima:", neki_broj);
                for (int i = 0; i < indexi.Count; i++)
                    Console.Write(indexi[i] + " ");
            }
            else
                Console.WriteLine("\nBroj {0} se ne nalazi u nizu", neki_broj);
        }
    }
}