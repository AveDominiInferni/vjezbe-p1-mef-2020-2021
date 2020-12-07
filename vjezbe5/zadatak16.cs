using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static int NajveciElement(int[] niz)
        {
            int max = niz[0];
            for (int i = 1; i < niz.Length; i++)
                if (niz[i] > max)
                    max = niz[i];
            return max;
        }
        static int NajmanjiElement(int[] niz)
        {
            int min = niz[0];
            for (int i = 1; i < niz.Length; i++)
                if (niz[i] < min)
                    min = niz[i];
            return min;
        }
        static void IspisElemenata(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static int[] SpojiNizove(int[] niz1, int[] niz2)
        {
            int[] spojeni_niz = new int[niz1.Length + niz2.Length];
            for (int i = 0; i < niz1.Length; i++)
                spojeni_niz[i] = niz1[i];
            for (int i = 0; i < niz2.Length; i++)
                spojeni_niz[i + niz1.Length] = niz2[i];
            return spojeni_niz;
        }
        static int SumaSvihElemenata(int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;
        }
        static double ProsjekVrijednost(int[] niz)
        {
            return SumaSvihElemenata(niz) / niz.Length;
        }
        static void AnalizirajNiz(int[] niz)
        {
            Console.WriteLine("Elementi niza:");
            IspisElemenata(niz);
            Console.WriteLine("Suma svih elemenata niza je " + SumaSvihElemenata(niz));
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] niz1 = { 1, 2, 3, 4, 5 };
            int[] niz2 = new int[niz1.Length * 2];
            for (int i = 0; i < niz2.Length; i++)
                niz2[i] = rnd.Next(-19, 20);
            Console.WriteLine("Unesite dimenziju treceg niza n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] niz3 = new int[n];
            Console.WriteLine("Unesite elemente treceg niza:");
            for (int i = 0; i < n; i++)
                niz3[i] = Convert.ToInt32(Console.ReadLine());
            int[] niz4 = SpojiNizove(SpojiNizove(niz1, niz2), niz3);
            Console.WriteLine("\nPrvi niz:");
            AnalizirajNiz(niz1);
            Console.WriteLine("\nDrugi niz:");
            AnalizirajNiz(niz2);
            Console.WriteLine("\nTreci niz:");
            AnalizirajNiz(niz3);
            Console.WriteLine("\nElementi svih nizova zajedno:");
            IspisElemenata(niz4);
            Console.WriteLine("Suma svih nizova zajedno je " + SumaSvihElemenata(niz4));
            Console.WriteLine("Prosjek vrijednosti svih nizova je " + ProsjekVrijednost(niz4));
            Console.WriteLine("Najveci element svih nizova je " + NajveciElement(niz4));
            Console.WriteLine("Najmanji element svih nizova je " + NajmanjiElement(niz4));
        }
    }
}