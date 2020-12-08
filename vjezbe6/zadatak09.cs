using System;
using System.Collections.Generic;

namespace vjezbe6
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Console.WriteLine("Potrebno je unijeti 5 unificiranih brojeva:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Vas broj je ");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (lista.Contains(temp))
                {
                    Console.WriteLine("Broj {0} se nalazi u listi. Ponoviti unos!", temp);
                    i--;
                }
                else
                    lista.Add(temp);
            }
            lista.Sort();
            Console.WriteLine("\nSvi elementi kolekcije sortirani od najmanjeg do najveceg su:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]);
                if (i != lista.Count - 1)
                    Console.Write(",");
            }
        }

    }
}