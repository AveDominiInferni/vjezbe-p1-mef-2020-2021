using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int[] ocjene = { 6, 8, 7, 8, 9 };
            double prosjek = 0;
            for (int i = 0; i < ocjene.Length; i++)
                prosjek += ocjene[i];
            prosjek /= ocjene.Length;
            Console.WriteLine("Prosjek: {0}", Math.Round(prosjek, 1));
        }
    }
}