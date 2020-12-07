using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisElemenata(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int[] niz1 = { 19, -5, 6, 9, 1 };
            int[] niz2 = new int[niz1.Length];
            for (int i = 0; i < niz1.Length; i++)
                niz2[i] = niz1[niz1.Length - i - 1];
            IspisElemenata(niz1);
            IspisElemenata(niz2);
        }
    }
}