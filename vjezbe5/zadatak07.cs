using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisElemenata(int[] niz)
        {
            Console.WriteLine("\nElementi niza:");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i]);
                if (i != niz.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int cijeli_broj;
            int[] niz = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Unesite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Broj {0}: ", i + 1);
                string unos = Console.ReadLine();
                if (Int32.TryParse(unos, out cijeli_broj))
                {
                    niz[i] = Convert.ToInt32(unos);
                }
                else
                {
                    Console.WriteLine("Unesena vrijednost \"{0}\" nije cijeli broj! Pokusajte ponovo.", unos);
                    i--;
                }
            }
            for (int i=0; i<5; i++)
                niz[i + 5] = rnd.Next(15, 56);
            IspisElemenata(niz);
        }
    }
}