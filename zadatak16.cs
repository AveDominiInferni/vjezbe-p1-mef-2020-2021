using System;

namespace vjezbe4
{ 
    class zadatak
    {
        static int Sabiranje1doN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
                suma += i;
            return suma;
        }
        static double Mnozenje1doN(int n)
        {
            double produkt = 1;
            for (int i = 1; i <= n; i++)
                produkt *= i;
            return produkt;
        }
        static double SrednjaVrijednost1doN(int n)
        {
            return Sabiranje1doN(n) / Convert.ToDouble(n);
        }
        static void Sabiranje1doNIspis(int n)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nSuma svih cijelih brojeva od 1 do {0} je {1}", n, Sabiranje1doN(n));
        }
        static void Mnozenje1doNIspis(int n)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nProdukt svih cijelih brojeva od 1 do {0} je {1}", n, Mnozenje1doN(n));
        }
        static void SrednjaVrijednost1doNIspis(int n)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nProsjek svih cijelih brojeva od 1 do {0} je {1}", n, SrednjaVrijednost1doN(n));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite granicnu vrijednsost:");
            int n = Convert.ToInt32(Console.ReadLine());
            Sabiranje1doNIspis(n);
            Mnozenje1doNIspis(n);
            SrednjaVrijednost1doNIspis(n);
        }
    }
}
