using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static void IspisBrojevaKorisnik()
        {
            Console.Write("\nUnesite vrijednost koraka iteracije: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (int i = 0; i <= 100; i += n)
                Console.Write(i + " ");
        }

        static void IspisBrojevaFiksniKorak()
        {
            Random rnd = new Random();
            int n = rnd.Next(5, 19);
            Console.Write("\n");
            for (int i = 0; i <= 100; i += n)
                Console.Write(i + " ");
        }
        static void IspisBrojevaPromjenljiviKorak()
        {
            Random rnd = new Random();
            int n;
            Console.Write("\n");
            for (int i = 0; i <= 100; i += n)
            {
                n = rnd.Next(5, 19);
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program ispisuje cijele brojeve od 0 do 100.\n");
            Console.WriteLine("Izaberi jednu od tri opcije:");
            Console.WriteLine(" 1) Korisnik unosi korak");
            Console.WriteLine(" 2) Program bira fiksan borak");
            Console.WriteLine(" 3) Program bira varijabilan korak\n");
            Console.Write("Vas izbor je: ");
            int izbor = Convert.ToInt32(Console.ReadLine());
            if (izbor == 1)
                IspisBrojevaKorisnik();
            else if (izbor == 2)
                IspisBrojevaFiksniKorak();
            else if (izbor == 3)
                IspisBrojevaPromjenljiviKorak();
            else
                Console.Write("\nGRESKA");
            Console.Write("\n");
        }
    }
}
