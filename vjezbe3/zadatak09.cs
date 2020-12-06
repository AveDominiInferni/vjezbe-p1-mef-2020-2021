using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            double broj;
            Console.WriteLine("Unesite dva realna broja:");
            Console.Write("Prvi broj = ");
            string prvi = Console.ReadLine();
            Console.Write("Drugi broj= ");
            string drugi = Console.ReadLine();
            Console.Write("\n");
            if (!Double.TryParse(prvi, out broj) && !Double.TryParse(drugi, out broj)) //Ako su oba neispravna
                Console.WriteLine("Greska pri unosu!\nOba unosa su neispravna.");
            else if (Double.TryParse(prvi, out broj) && !Double.TryParse(drugi, out broj)) //Ako je drugi neispravan
                Console.WriteLine("Greska pri unosu!\nDrugi unos \"{0}\" nije realan broj.", drugi);
            else if (!Double.TryParse(prvi, out broj) && Double.TryParse(drugi, out broj)) //Ako je prvi neispravan
                Console.WriteLine("Greska pri unosu!\nPrvi unos \"{0}\" nije realan broj.", prvi);
            else
            {
                double br1 = Convert.ToDouble(prvi);
                double br2 = Convert.ToDouble(drugi);
                if (br1 == br2) Console.WriteLine("Uneseni brojevi su jednaki.");
                else if (br1 > br2) Console.WriteLine("Prvi uneseni broj {0} je veci od drugog unesenog {1}.", prvi, drugi);
                else Console.WriteLine("Drugi uneseni broj {0} je veci od prvog unesenog {1}.", drugi, prvi);
            }
        }
    }
}
