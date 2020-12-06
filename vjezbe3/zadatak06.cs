using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static int BrojCifara(int n)
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
            Console.WriteLine("Unesite jedan pozitivan cijeli broj");
            int n = Convert.ToInt32(Console.ReadLine());
            int broj_cifara = BrojCifara(n);
            if (broj_cifara == 1)
                Console.WriteLine("\nUneseni broj {0} je jednocifren.", n);
            else if (broj_cifara == 2)
                Console.WriteLine("\nUneseni broj {0} je dvocifren.", n);
            else if (broj_cifara == 3)
                Console.WriteLine("\nUneseni broj {0} je trocifren.", n);
        }
    }
}
