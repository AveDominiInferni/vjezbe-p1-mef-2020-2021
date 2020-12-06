using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            string unos;
            Console.WriteLine("Pocetak programa");
            Console.WriteLine("==============================================================");
            do
            {
                Console.WriteLine("\nIZVRSAVANJE NEKOG PROGRAMA");
                Console.WriteLine("\nUnesite 0/Izlaz ukoliko zelite da se program zaustavi:");
                unos = Console.ReadLine();
            } while (unos.ToLower() != "izlaz" && unos != "0");
            Console.WriteLine("\n==============================================================\nKraj programa");
        }
    }
}
