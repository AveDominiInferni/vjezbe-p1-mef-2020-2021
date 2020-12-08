using System;
using System.Collections.Generic;
using System.IO;

namespace _1._4_Zadatak_13_
{
    class Program
    {
        static void Main()
        {
            // Formiranje niza popunjen nasumičnim vrijednostima
            int[] niz = new int[60];
            Random rng = new Random();

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rng.Next(-50, 51);
            }


            int[] nizTrazenihElemenata = new int[3];

            nizTrazenihElemenata[0] = 17;

            Console.Write("Unesite element koji zelite pretraziti u nizu: ");
            nizTrazenihElemenata[1] = int.Parse(Console.ReadLine());

            nizTrazenihElemenata[2] = rng.Next(1, 31);

            // Za svaki trazeni element u nizu trazenih elemenata:
            foreach (int trazeniElem in nizTrazenihElemenata)
            {
                int indexTrazenog = LinearnoPretrazivanje(niz, trazeniElem);

                if (indexTrazenog == -1)
                    Console.WriteLine($"\nTrazeni element {trazeniElem} se ne nalazi u nizu.");

                else
                    Console.WriteLine($"\nTrazeni element {trazeniElem} se nalazi u nizu na {indexTrazenog} indexu.");
            }

            Console.ReadKey();

        }

        static int LinearnoPretrazivanje(int[] nekiNiz, int trazeniElement)
        {
            for (int i = 0; i < nekiNiz.Length; i++)
            {
                if (nekiNiz[i] == trazeniElement)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }
    }

}