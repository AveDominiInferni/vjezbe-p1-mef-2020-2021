using System;
using System.Collections.Generic;

namespace _2._8_Zadatak_27_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite proizvoljan tekst sastavljen od brojeva i/li riječi:");
            string input = Console.ReadLine();

            string[] nizStr = input.Split(' ');
            List<double> brojevi = new List<double>();
            List<string> rijeci = new List<string>();

            foreach (string item in nizStr)
            {
                bool realanBroj = double.TryParse(item, out double broj);

                if (realanBroj)
                    brojevi.Add(broj);
                else
                    rijeci.Add(item);
            }
            double varijabla = 0;
            foreach(var element in brojevi)
            {
                varijabla = varijabla + element; 
            }
            Console.WriteLine($"\nSve rijeci iz unesenog stringa: \n{string.Join(", ", rijeci)}");
            Console.WriteLine($"\nSuma svih brojeva iz unesenog stringa je {Math.Round(varijabla, 2)}");

            Console.ReadKey();
        }

    }
}