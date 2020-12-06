using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva realna broja:");
            Console.Write("Prvi broj = ");
            double prvi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Drugi broj= ");
            double drugi = Convert.ToDouble(Console.ReadLine());
            if (prvi == drugi) 
                Console.WriteLine("\nUneseni brojevi su jednaki.");
            else if (prvi > drugi) 
                Console.WriteLine("\nPrvi uneseni broj {0} je veci od drugog unesenog {1}", prvi, drugi);
            else 
                Console.WriteLine("\nDrugi uneseni broj {0} je veci od prvog unesenog {1}", drugi, prvi);
        }
    }
}
