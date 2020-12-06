using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("Unesite jedan pozitivan cijeli broj");
            string unos = Console.ReadLine();
            if (UInt32.TryParse(unos, out n))
            {
                n = Convert.ToUInt32(unos);
                if (n == 0)
                    Console.WriteLine("\nUnijeli ste 0.");
                else if (n % 2 == 0)
                    Console.WriteLine("\nUneseni broj {0} je paran broj.", n);
                else
                    Console.WriteLine("\nUneseni broj {0} je neparan broj.", n);
            }
            else
                Console.WriteLine("\nUneseni broj {0} nije pozitivan cijeli broj.", unos);
        }
    }
}
