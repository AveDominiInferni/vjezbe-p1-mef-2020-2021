using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli broj");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("\nBroj {0} je pozitivan.", n);
            else if (n < 0)
                Console.WriteLine("\nBroj {0} je negativan.", n);
            else
                Console.WriteLine("\nUnijeli ste 0.");
        }
    }
}
