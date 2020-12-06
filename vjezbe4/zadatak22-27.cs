using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static int Sabiranje1doN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
                suma += i;
            return suma;
        }
        static void Main(string[] args)
        {
            string unos;
            do
            {
                uint broj;
                bool ispravan_unos;
                do
                {
                    Console.Write("Unesite pozitivan cijeli broj do kojeg zelite da program sumira sve prirodne brojeve: ");
                    unos = Console.ReadLine();
                    ispravan_unos = uint.TryParse(unos, out broj);
                    if (!ispravan_unos)
                        Console.WriteLine("Niste unijeli pozitivan cijeli broj!\n");
                } while (!ispravan_unos);
                int n = Convert.ToInt32(unos);
                int numLimit = Convert.ToInt32(unos);
                int totalSum = Sabiranje1doN(n);
                Console.WriteLine("\nSuma cijelih brojeva od 1 do {0} je jednaka {1}", n, Sabiranje1doN(n));
                do
                {
                    Console.WriteLine("\nDa li zelite ponoviti program (DA/NE)?");
                    unos = Console.ReadLine();
                    ispravan_unos = unos.ToUpper() == "DA" || unos.ToUpper() == "NE";
                    if (!ispravan_unos)
                        Console.WriteLine("\nUnos mora biti DA ili NE!");
                } while (!ispravan_unos);
            } while (unos.ToUpper() != "NE");
            Console.WriteLine("\nKraj programa!");
        }
    }
}
