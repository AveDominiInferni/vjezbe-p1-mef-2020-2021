using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            long suma = 0;
            Console.Write("Unesite granicnu vrijednost: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    suma += i;
            }
            Console.WriteLine("\nSuma svih cijelih brojeva od 1 do {0} koji su djeljivi sa 3 ili sa 5 je {1}", n - 1, suma);
        }
    }
}
