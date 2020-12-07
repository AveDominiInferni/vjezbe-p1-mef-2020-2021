using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisElemenata(double[] niz)
        {
            Console.WriteLine("\n");
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
            Random rnd = new Random();
            double min = 50, max = 100;
            Console.Write("Unesite dimenzije niza N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] niz = new double[n];
            Console.Write("\n");
            for (int i=0; i<n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Unesite vrijednost: ");
                    niz[i] = Convert.ToDouble(Console.ReadLine());
                }
                else if (i % 3 == 1)
                    niz[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
                else
                    niz[i] = i;  
            }
            IspisElemenata(niz);
        }
    }
}