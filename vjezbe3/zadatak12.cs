using System;
using System.Collections.Generic;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            double broj;
            Console.WriteLine("Unesite tri realna broja:");
            string br1 = Console.ReadLine();
            string br2 = Console.ReadLine();
            string br3 = Console.ReadLine();
            bool br1_ispravan = Double.TryParse(br1, out broj);
            bool br2_ispravan = Double.TryParse(br2, out broj);
            bool br3_ispravan = Double.TryParse(br3, out broj);
            if (!br1_ispravan || !br2_ispravan || !br3_ispravan)
            {
                Console.WriteLine("Pogresan unos:");
                if (!br1_ispravan) Console.WriteLine("\t{0} nije realan broj!", br1);
                if (!br2_ispravan) Console.WriteLine("\t{0} nije realan broj!", br2);
                if (!br3_ispravan) Console.WriteLine("\t{0} nije realan broj!", br3);
            }
            else
            {
                Console.WriteLine("\nUneseni brojevi sortirani od najmanjeg do najveceg:");
                List<double> lista = new List<double>();
                lista.Add(Convert.ToDouble(br1));
                lista.Add(Convert.ToDouble(br2));
                lista.Add(Convert.ToDouble(br3));
                lista.Sort();
                foreach (double x in lista)
                    Console.Write(x + " ");
            }
        }
    }
}
