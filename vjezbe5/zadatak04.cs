using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            double[] ocjene = { -6.2, 5, -2, -53, 24, 0, 14, 32.23 };
            Console.WriteLine("Elementi su:");
            for (int i = 0; i < ocjene.Length; i++)
                Console.Write(ocjene[i] + " ");
        }
    }
}