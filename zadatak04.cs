using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i;
            Console.WriteLine("15 nasumicno odabranih cijelih brojeva u rasponu od 5 do 55:\n");
            for (i = 0; i < 15; i++)
                Console.Write(rnd.Next(5, 56) + " ");
            i = 0;
            Console.Write("\n");
            while (i < 15)
            {
                Console.Write(rnd.Next(5, 56) + " ");
                i++;
            }
            i = 0;
            Console.Write("\n");
            do
            {
                Console.Write(rnd.Next(5, 56) + " ");
                i++;
            } while (i < 15);
        }
    }
}
