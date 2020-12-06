using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int skriveni_broj = rnd.Next(1, 11);
            int broj_pokusaja = 3;
            do
            {
                Console.WriteLine("Pokusajte pogoditi skriveni broj koji se nalazi u intervalu od 1 do 10.");
                Console.WriteLine("Broj preostalih pokusaja: " + broj_pokusaja);
                Console.Write("Vas broj je: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n != skriveni_broj)
                    Console.WriteLine("Uneseni broj {0} nije skriveni broj.\n", n);
                else
                {
                    Console.WriteLine("\nCestitamo! Uneseni broj {0} je skriveni broj.\n", n);
                    return;
                }
                broj_pokusaja--;
            } while (broj_pokusaja > 0);
            Console.WriteLine("Igra je gotova. Skriveni broj je {0}.", skriveni_broj);
        }
    }
}
