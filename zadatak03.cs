using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
                Console.WriteLine(i);
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
    }
}
