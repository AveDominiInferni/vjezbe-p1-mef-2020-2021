using System;

namespace vjezbe6
{ 
    class zadatak
    {
        static void Zamijeni(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva realna broja:");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine("\nPrije zamjene:\n a = {0}   b = {1}", a, b);
                Zamijeni(ref a, ref b);
                Console.WriteLine("\nNakon zamjene:\n a = {0}   b = {1}", a, b);
            }
        }
    }
}