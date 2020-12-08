using System;

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
        static void Zamijeni(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void BubbleSort(ref int[] niz)
        {
            bool sortiran;
            do
            {
                sortiran = true;
                for (int i = 0; i < niz.Length - 1; i++)
                {
                    if (niz[i] > niz[i + 1])
                    {
                        Zamijeni(ref niz[i], ref niz[i + 1]);
                        sortiran = false;
                    }
                }
            } while (!sortiran);
        }
        static bool ProvjeriRastuciPoredak(int[] niz)
        {
            for (int i = 0; i < niz.Length - 1; i++)
                if (niz[i] > niz[i + 1])
                    return false;
            return true;
        }
        static bool ProvjeriOpadajuciPoredak(int[] niz)
        {
            for (int i = 0; i < niz.Length - 1; i++)
                if (niz[i] < niz[i + 1])
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int[] niz = new int[5];
            Console.WriteLine("Unesite 5 elemenata niza:");
            for (int i = 0; i < 5; i++)
                niz[i] = Convert.ToInt32(Console.ReadLine());
            if (ProvjeriOpadajuciPoredak(niz) || ProvjeriRastuciPoredak(niz))
            {
                Console.WriteLine("\nNiz je vec sortiran! Elementi niza:");
                IspisNizova(niz);
            }
            else
            {
                Console.WriteLine("\nElementi nakon sortiranja niza:");
                BubbleSort(ref niz);
                IspisNizova(niz);
            }
        }
    }
}