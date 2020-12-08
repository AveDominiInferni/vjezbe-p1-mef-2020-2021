using System;

namespace vjezbe6
{ 
    class zadatak
    {
        static void IspisNizova(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                Console.Write(niz[i] + " ");
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] niz = new int[60];
            for (int i = 0; i < niz.Length; i++)
                niz[i] = rnd.Next(-50, 51);
            Console.WriteLine("Elementi niza:");
            IspisNizova(niz);
            for (; ; )
            {
                Console.WriteLine("\nUnesite vrijednost koju zelite pretraziti:");
                string unos = Console.ReadLine();
                if (unos.ToLower() == "izlaz")
                    break;
                else
                {
                    int broj = Convert.ToInt32(unos);
                    bool nalazi_se = false;
                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (niz[i] == broj)
                        {
                            Console.WriteLine("Broj {0} se nalazi na indexu {1}", broj, i);
                            nalazi_se = true;
                            break;
                        }
                    }
                    if (!nalazi_se)
                        Console.WriteLine("Broj {0} se ne nalazi u nizu", broj);
                }
            }
        }
    }
}