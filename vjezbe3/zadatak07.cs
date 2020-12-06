using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static int BrojCifara(uint n)
        {
            int broj_cifara = 0;
            while (n > 0)
            {
                n = n / 10;
                broj_cifara++;
            }
            return broj_cifara;
        }
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("Unesite jedan pozitivan cijeli broj");
            string unos = Console.ReadLine();
            if (UInt32.TryParse(unos, out n))
            {
                n = Convert.ToUInt32(unos);
                int broj_cifara = BrojCifara(n);
                if (broj_cifara == 1)
                    Console.WriteLine("\nUneseni broj {0} je jednocifren.", n);
                else if (broj_cifara == 2)
                    Console.WriteLine("\nUneseni broj {0} je dvocifren.", n);
                else if (broj_cifara == 3)
                    Console.WriteLine("\nUneseni broj {0} je trocifren.", n);
            }
            else
                Console.WriteLine("Unesena vrijednost \"{0}\" nije pozitivan cijeli broj.", unos);
        }
    }
}
