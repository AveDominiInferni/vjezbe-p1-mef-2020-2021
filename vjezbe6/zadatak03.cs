using System;

namespace vjezbe6
{ 
    class zadatak
    {
        static void Zamijeni(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Prije zamjene:\n a = {0}   b = {1}", a, b);
            Zamijeni(ref a, ref b);
            Console.WriteLine("\nNakon zamjene:\n a = {0}   b = {1}", a, b);
        }
    }
}