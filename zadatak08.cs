using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            Console.Write("Program proizvoljno odredjuje varijabilan korak iteracije za ispis brojeva u rasponu od 0 do 100\n\n");
            for (int i = 0; i <= 100; i += n)
            {
                n = rnd.Next(5, 19);
                Console.Write(i);
                if (i + n <= 100)
                    Console.Write(",");
            }
            Console.Write(".\n");
        }
    }
}
