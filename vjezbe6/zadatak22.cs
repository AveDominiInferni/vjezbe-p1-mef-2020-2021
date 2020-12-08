using System;

namespace _22.Zadatak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite proizvoljan tekst");
            string tekst = Console.ReadLine();
            int brojaca = 0;
            int brojace = 0;
            int brojaci = 0;
            int brojaco = 0;
            int brojacu = 0;
            string a = "a";

            foreach (char slovo in tekst)
            {
                if (slovo == 'a' || slovo == 'A')
                {
                    brojaca++; 
                }
                if (slovo == 'e' || slovo == 'E')
                {
                    brojace++;
                }
                if (slovo == 'i' || slovo == 'I')
                {
                    brojaci++;
                }
                if (slovo == 'o' || slovo == 'O')
                {
                    brojaco++;
                }
                if (slovo == 'u' || slovo == 'U')
                {
                    brojacu++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"U tekstu se samoglasnik a pojavljuje {brojaca} puta");
            Console.WriteLine($"U tekstu se samoglasnik e pojavljuje {brojace} puta");
            Console.WriteLine($"U tekstu se samoglasnik i pojavljuje {brojaci} puta");
            Console.WriteLine($"U tekstu se samoglasnik o pojavljuje {brojaco} puta");
            Console.WriteLine($"U tekstu se samoglasnik u pojavljuje {brojacu} puta");

            Console.ReadKey();
        }
    }
}
