using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisElemenata(double[] niz)
        {
            Console.WriteLine("Elementi niza su:");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i]);
                if (i != niz.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("\n");
        }
        static double NajmanjiElement(double[] niz)
        {
            double min = niz[0];
            for (int i = 1; i < niz.Length; i++)
                if (niz[i] < min)
                    min = niz[i];
            return min;
        }
        static double ProsjekSvihElemenata(double[] niz)
        {
            double suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma / niz.Length;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double min = -100, max = 100;
            double[] niz = new double[40];
            for (int i = 0; i < 40; i++)
                niz[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
            IspisElemenata(niz);
            Console.WriteLine("\nNajmanji broj iz niza je " + NajmanjiElement(niz));
            Console.WriteLine("Prosjek svih elemenata je " + Math.Round(ProsjekSvihElemenata(niz), 1));
        }
    }
}