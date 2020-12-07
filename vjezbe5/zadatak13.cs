using System;
using System.Collections.Generic;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisNiza(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static void IspisListe(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + " ");
            Console.Write("\n");
        }
        static List<int> VratiKolekcijuURasponu(int[] niz, int min, int max)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < niz.Length; i++)
                if (niz[i] >= min && niz[i] <= max)
                    lista.Add(niz[i]);
            return lista;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] niz = new int[50];
            for (int i = 0; i < 50; i++)
                niz[i] = rnd.Next(1, 451);
            List<int> l1 = VratiKolekcijuURasponu(niz, 1, 150);
            List<int> l2 = VratiKolekcijuURasponu(niz, 151, 300);
            List<int> l3 = VratiKolekcijuURasponu(niz, 301, 450);
            Console.WriteLine("Elementi pocetne kolekcije:");
            IspisNiza(niz);
            Console.WriteLine("\nElementi pocetne kolekcije u opsegu 1 do 150:");
            IspisListe(l1);
            Console.WriteLine("\nElementi pocetne kolekcije u opsegu 151 do 350:");
            IspisListe(l2);
            Console.WriteLine("\nElementi pocetne kolekcije u opsegu 301 do 450:");
            IspisListe(l3);
        }
    }
}