using System;
using System.Collections.Generic;

namespace _30.Zadatak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite zeljeni tekst tako da su rijeci odvojene samo zarezom:");
            string unos = Console.ReadLine();
            string[] tekst = unos.Split(',');

            List<double> realniBrojevi = new List<double>();
            foreach(var element in tekst)
            {
                if (double.TryParse(element, out double br1))
                {
                    realniBrojevi.Add(br1);
                }

            }
            double referent;
            for (int i = 0; i < realniBrojevi.Count; i++)
            {
                for(int j = i + 1; j < realniBrojevi.Count; j++)
                {
                    if(realniBrojevi[i] > realniBrojevi[j])
                    {
                        referent = realniBrojevi[i];
                        realniBrojevi[i] = realniBrojevi[j];
                        realniBrojevi[j] = referent;
                    }
                }
            }
            Console.WriteLine("\nSortirani brojevi izvuceni iz teksta:");
            foreach(var element2 in realniBrojevi)
            {
                Console.Write(element2 + " ");
            }
            Console.WriteLine();

            Console.ReadKey();



        }
    }
}
