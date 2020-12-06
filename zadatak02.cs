using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Unesite raspon u kojem zelite da program nasumicno bira brojeve:");
            double n1, n2;
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                double temp = n1;
                n1 = n2;
                n2 = temp;
            }
            double broj = Math.Round(rnd.NextDouble() * (n2 - n1) + n1, 2);
            Console.WriteLine("\nNasumicno odabrana vrijednost u rasponu od {0} do {1} je {2}", n1, n2, broj);
        }
    }
}
