using System;
using System.Collections.Generic;

namespace vjezbe5
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int[] niz = new int[5];
            List<int> lista = new List<int>();
            Console.WriteLine("Unesite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Broj {0}: ", i + 1);
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nElementi niza:");
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            lista.AddRange(niz);
            lista.Add(19);
            lista.Add(87);
            Console.WriteLine("\n\nElementi liste:");
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + " ");
        }
    }
}