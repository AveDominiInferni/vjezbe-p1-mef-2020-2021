using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    suma += i;
            }
            Console.WriteLine("Suma svih cijelih brojeva od 1 do 999 koji su djeljivi sa 3 ili sa 5 je " + suma);
        }
    }
}
