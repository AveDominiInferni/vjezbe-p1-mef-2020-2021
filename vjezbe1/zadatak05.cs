using System;

namespace vjezbe1
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            int[] niz = { -66, 21, 71, 33 };
            Console.WriteLine("Elementi niza su:");
            for (int i = 0; i < niz.Length; i++)
            {
                if (i == niz.Length - 1)
                    Console.WriteLine(" i {0}\n", niz[i]);
                else
                    Console.Write("{0},", niz[i]);
            }
            Console.WriteLine("Duzina niza je {0}, tj. niz se sastoji od {0} elementa", niz.Length);
        }
    }
}
