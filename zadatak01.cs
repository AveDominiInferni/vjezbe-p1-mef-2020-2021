using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double n1 = rnd.NextDouble();
            int n2 = rnd.Next(50, 91);
            double n3 = rnd.NextDouble() * (90.0 - 50.0) + 50.0;
            Console.WriteLine(Math.Round(n1, 2));
            Console.WriteLine(n2);
            Console.WriteLine(Math.Round(n3, 2));
        }
    }
}
