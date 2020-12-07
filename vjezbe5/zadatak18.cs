using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisElemenata(int[] niz)
        {
            Console.Write("[");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i]);
                if (i != niz.Length - 1)
                    Console.Write(",");
            }
            Console.Write("]\n");
        }
        static int[] VratiPodniz(int[] niz, int d)
        {
            int[] temp = new int[d];
            for (int i = 0; i < d; i++)
                temp[i] = niz[i];
            return temp;
        }
        static int[] VratiObrnutiNiz(int[] niz)
        {
            int[] obrnuti = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
                obrnuti[i] = niz[niz.Length - i - 1];
            return obrnuti;
        }
        static void Main(string[] args)
        {
            int[] niz1 = new int[6];
            Console.WriteLine("Unesite 6 elemenata niza:");
            for (int i = 0; i < 6; i++)
                niz1[i] = Convert.ToInt32(Console.ReadLine());
            int[] niz2 = VratiPodniz(niz1, 3);
            int[] niz3 = VratiPodniz(VratiObrnutiNiz(niz1), 3);
            Console.Write("\nOriginalni niz: ");           
            IspisElemenata(niz1);
            Console.Write("\nPrva kopija: ");
            IspisElemenata(niz2);
            Console.Write("\nDruga kopija: ");
            IspisElemenata(niz3);
        }
    }
}