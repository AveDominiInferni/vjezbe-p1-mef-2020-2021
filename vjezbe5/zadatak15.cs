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
            int[] orgNiz = { 19, -5, 6, 9, 11 };
            int[] kopiNiz = new int[orgNiz.Length];
            for (int i = 0; i < kopiNiz.Length; i++)
                kopiNiz[i] = orgNiz[i];
            orgNiz[3] = 0;
            Console.WriteLine("orgNiz:");
            IspisElemenata(orgNiz);
            Console.WriteLine("kopiNiz:");
            IspisElemenata(kopiNiz);
        }
    }
}