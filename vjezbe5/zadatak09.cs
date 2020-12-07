using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisElemenata(int[] niz)
        {
            Console.WriteLine("Elementi niza su:");
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static int NajveciElement(int[] niz)
        {
            int max = niz[0];
            for (int i = 1; i < niz.Length; i++)
                if (niz[i] > max)
                    max = niz[i];
            return max;
        }
        static int SumaSvihElemenata(int [] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] niz = new int[30];
            for (int i = 0; i < 30; i++)
                niz[i] = rnd.Next(-200, 201);
            IspisElemenata(niz);
            Console.WriteLine("\nNajveci broj iz niza je " + NajveciElement(niz));
            Console.WriteLine("Suma svih elemenata niza je " + SumaSvihElemenata(niz));
        }
    }
}