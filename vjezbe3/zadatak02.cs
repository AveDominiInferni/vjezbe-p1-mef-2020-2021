using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Unesite jedan cijeli broj");
            string unos = Console.ReadLine();
            if (Int32.TryParse(unos, out n))
            {
                n = Convert.ToInt32(unos);
                if (n > 0)
                    Console.WriteLine("\nBroj {0} je pozitivan.", n);
                else if (n < 0)
                    Console.WriteLine("\nBroj {0} je negativan.", n);
                else
                    Console.WriteLine("\nBroj je 0.");
            }
            else
                Console.WriteLine("\nUneseni broj {0} nije cijeli broj", unos);
        }
    }
}
