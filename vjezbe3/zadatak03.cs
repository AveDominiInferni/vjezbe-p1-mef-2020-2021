using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan pozitivan cijeli broj");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("\nUneseni broj {0} je paran broj.", n);
            else
                Console.WriteLine("\nUneseni broj {0} je neparan broj.", n);

        }
    }
}
