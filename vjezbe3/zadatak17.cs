using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izabrati boju u kojoj zelite da ispisete poruku u konzolnom prozoru:");
            Console.WriteLine(" a) plava");
            Console.WriteLine(" b) crvena");
            Console.WriteLine(" c) zuta");
            Console.WriteLine(" d) zelena");
            Console.WriteLine(" e) ljubicasta");
            Console.Write("Vas izbor je: ");
            string unos = Console.ReadLine();
            if (unos.ToLower() == "a" || unos.ToLower() == "plava")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nISPIS PORUKE U PLAVOJ BOJI...");
            }
            else if (unos.ToLower() == "b" || unos.ToLower() == "crvena")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nISPIS PORUKE U CRVENOJ BOJI...");
            }
            else if (unos.ToLower() == "c" || unos.ToLower() == "zuta")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nISPIS PORUKE U ZUTOJ BOJI...");
            }
            else if (unos.ToLower() == "d" || unos.ToLower() == "zelena")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nISPIS PORUKE U ZELENOJ BOJI...");
            }
            else if (unos.ToLower() == "e" || unos.ToLower() == "ljubicasta")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nISPIS PORUKE U LJUBICASTOJ BOJI...");
            }
            else
                Console.WriteLine("\nUnos nije prihvatljiv!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
