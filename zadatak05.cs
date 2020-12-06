using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 100; i += 5)
                Console.Write(i + " ");
            i = 0;
            Console.Write("\n");
            while (i <= 100)
            {
                Console.Write(i + " ");
                i += 5;
            }
            i = 0;
            Console.Write("\n");
            do
            {
                Console.Write(i + " ");
                i += 5;
            } while (i <= 100);
        }
    }
}
