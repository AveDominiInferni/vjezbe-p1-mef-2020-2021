using System;

namespace vjezbe2
{ 
    class zadatak
    {
        static double UnosUglaIPretvaranjeIzDegURad()
        {
            return Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite uglove alpha, beta i gama u stepenima:");
            Console.Write("alpha = ");
            double alpha = UnosUglaIPretvaranjeIzDegURad();
            Console.Write("beta = ");
            double beta = UnosUglaIPretvaranjeIzDegURad();
            Console.Write("gama = ");
            double gama = UnosUglaIPretvaranjeIzDegURad();
            double y = (Math.Sin(alpha + Math.PI) + Math.Sin((alpha + beta) / 11) + 3) / (Math.Tan(beta - alpha) - 2 * Math.Cos(gama) - Math.PI);
            Console.WriteLine("\nRezultat y = {0}", y);
        }
    }
}
