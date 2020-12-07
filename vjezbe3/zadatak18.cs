using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite vrijednost duzine u metrima m = ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nOdaberite broj za jedinice u koje zelite konvertovati metre");
            Console.Write("\n 1.Mikrometri");
            Console.Write("\n 2.Milimetri");
            Console.Write("\n 3.Centimetri");
            Console.Write("\n 4.Decimetri");
            Console.Write("\n 5.Kilometri");
            Console.Write("\nVas izbor je broj: ");
            int izbor = Convert.ToInt32(Console.ReadLine());
            if (izbor == 1)
                Console.WriteLine("\nKonverzija: {0} [m] = {1} [μm]", n, n * 1000000);
            else if (izbor == 2)
                Console.WriteLine("\nKonverzija: {0} [m] = {1} [mm]", n, n * 1000);
            else if (izbor == 3)
                Console.WriteLine("\nKonverzija: {0} [m] = {1} [cm]", n, n * 100);
            else if (izbor == 4)
                Console.WriteLine("\nKonverzija: {0} [m] = {1} [dm]", n, n * 10);
            else if (izbor == 5)
                Console.WriteLine("\nKonverzija: {0} [m] = {1} [km]", n, n / 1000);
            else
                Console.WriteLine("\nUnos nije prihvatljiv!");
        }
    }
}
