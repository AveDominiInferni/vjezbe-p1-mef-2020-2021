using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static int SumaUIntervalu(int a, int b)
        {
            int suma = 0;
            for (int i = a; i <= b; i++)
                suma += i;
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Suma svih cijelih brojeva od 1 do 100 je " + SumaUIntervalu(1, 100));
        }
    }
}
