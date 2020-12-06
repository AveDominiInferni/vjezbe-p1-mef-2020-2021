using System;

namespace vjezbe4
{ 
    class zadatak
    {
       static long Faktorijel(int n)
        {
            if (n == 0) return 1;
            long rezultat = 1;
            for (int i = 2; i <= n; i++)
                rezultat = rezultat * i;
            return rezultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vrijednost za koju zelite izracunati faktorijel:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nRezultat:\n{0}! = {1}", n, Faktorijel(n));
        }
    }
}
