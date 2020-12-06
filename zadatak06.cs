using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj koji odredjuje korak iteracije za ispis brojeva u rasponu od 0 do 100 --> ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (int i = 0; i <= 100; i += n)
                Console.Write(i + " ");
            Console.Write("\n\n");
            for (int i = 0; i <= 100; i += n)
            {
                Console.Write(i);
                if (i + n <= 100)
                    Console.Write(",");
            }
            Console.Write(".\n");
        }
    }
}
