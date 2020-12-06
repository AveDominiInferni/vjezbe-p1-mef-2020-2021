using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis brojeva:");
            for (int i = 10; i <= 75; i++)
            {
                if (i % 8 == 0 && i % 3 == 0)
                    continue;
                Console.Write(i + " ");
            }
        }
    }
}
