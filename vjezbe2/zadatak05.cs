using System;

namespace vjezbe2
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite vrijednost x:\nx = ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double y = (Math.Pow(x, 5.0 / 3.0) - Math.Pow(Math.E, 0.5 * x)) / (Math.Abs(x - 4) - Math.Sin(76 * Math.PI / 180));
            Console.WriteLine("\ny = {0}", Math.Round(y, 4));
        }
    }
}
