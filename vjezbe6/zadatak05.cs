using System;

namespace vjezbe6
{ 
    class zadatak
    {
        static void Zamijeni(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void BubbleSort(ref int[] niz)
        {
            bool sortiran;
            do
            {
                sortiran = true;
                for (int i = 0; i < niz.Length - 1; i++)
                {
                    if (niz[i] > niz[i + 1])
                    {
                        Zamijeni(ref niz[i], ref niz[i + 1]);
                        sortiran = false;
                    }
                }
            } while (!sortiran);
        }
        static void Main(string[] args)
        {
            int[] niz = { 11, 19, 9, -5, 0 };
            BubbleSort(ref niz);
            Console.WriteLine("Niz nakon sortiranja:");
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
        }
    }
}