using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            double min = -15, max = 20;
            Console.WriteLine("Unesite velicinu niza n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] niz = new double[n];
            Random rnd = new Random();
            for (int i=0; i<n; i++)
                niz[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
            Console.WriteLine("\nElementi niza:");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i]);
                if (i != niz.Length - 1)
                    Console.Write(",");
            }
			Console.Write("\n");
        }
    }
}