using System;

namespace vjezbe6
{ 
    class zadatak
    {
        static int[] KopiranjeNizova(int[] niz) // nije bilo potrebe da je koristimo
        {
            int[] kopija = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
                kopija[i] = niz[i];
            return kopija;
        }
        static void Zamijeni(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int[] SortiranjeNizova(int[] niz) 
        {
            bool sortiran;
            do
            {
                sortiran = true;
                for (int i = 0; i < niz.Length - 1; i++)
                {
                    if (niz[i] < niz[i + 1])
                    {
                        Zamijeni(ref niz[i], ref niz[i + 1]);
                        sortiran = false;
                    }
                }
            } while (!sortiran);
            return niz;
        }
        static void IspisNizova(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Unesite duzinu niza N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[n];
            for (int i = 0; i < n; i++)
                niz[i] = rnd.Next(-10, 51);
            Console.WriteLine("\nPrvi niz:");
            IspisNizova(niz);
            int[] kopija = SortiranjeNizova(niz);
            Console.WriteLine("\nDrugi niz:");
            IspisNizova(kopija);
        }
    }
}
