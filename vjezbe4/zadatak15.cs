using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static long Faktorijel(int n)
        {
            if (n == 0) return 1;
            long rezultat = 1;
            for (int i = 2; i <= n; i++)
                rezultat = rezultat * i;
            return rezultat;
        }
        static long BinomniObrazac(int n, int k)
        {
            return Faktorijel(n) / Faktorijel(k) / Faktorijel(n - k);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vrijednost n i k i program ce izracunati binomni obrazac n nad k:");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBinomni obrazac {0} nad {1} je jednak {2}", n, k, BinomniObrazac(n, k));
        }
    }
}
