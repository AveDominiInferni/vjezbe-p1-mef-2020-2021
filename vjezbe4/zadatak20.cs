using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite pozitivan cijeli broj i program ce redukovati taj broj do broja 1:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n" + n);
            while (n != 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = 3 * n + 1;
                Console.Write(" -> " + n);
            }
        }
    }
}
