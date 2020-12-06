using System;

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
            Console.Write("\n");
            if (!br1_ispravan || !br2_ispravan || !br3_ispravan)
            {
                Console.WriteLine("Pogresan unos:");
                if (!br1_ispravan) Console.WriteLine("\t{0} nije realan broj!", br1);
                if (!br2_ispravan) Console.WriteLine("\t{0} nije realan broj!", br2);
                if (!br3_ispravan) Console.WriteLine("\t{0} nije realan broj!", br3);
            }
            else
            {
                double broj1 = Convert.ToDouble(br1);
                double broj2 = Convert.ToDouble(br2);
                double broj3 = Convert.ToDouble(br3);
                double zbir = broj1 + broj2 + broj3;
                double proizvod = broj1 * broj2 * broj3;
                Console.WriteLine("{0} + {1} + {2} = {3}", br1, br2, br3, Math.Round(zbir, 2));
                Console.WriteLine("{0} * {1} * {2} = {3}", br1, br2, br3, Math.Round(proizvod, 2));
            }
        }
    }
}
