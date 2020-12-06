using System;
using System.Collections.Generic;

namespace vjezbe1
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            double[] niz = { -14, 5.53, 0.3, 12, 0.3, -0.052 };
            lista.AddRange(niz); //Moze i sa lista.Add(x), pa svaki broj pojedinacno
            Console.WriteLine("Prije brisanja elemenata lista je imala - {0} elemenata.\n", lista.Count);
            lista.Remove(0.3);
            Console.WriteLine("Nakon brisanja lista ima - {0} elemenata", lista.Count);
        }
    }
}
