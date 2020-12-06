using System;

namespace vjezbe2
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva broja:");
            double br1, br2;
            br1 = Convert.ToDouble(Console.ReadLine());
            br2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPrvi broj je jednak drugom i prvi broj je veci od 1 - {0}", br1 == br2 && br1 > 1);
            Console.WriteLine("Drugi broj je veci od prvog ili je drugi broj negativan - {0}", br2 > br1 || br2 < 0);
            Console.WriteLine("Prvi broj je ili veci od drugog ili su oni nejednaki - {0}", br1 > br2 || br1 != br2);
            Console.WriteLine("Niti je prvi broj pozitivan niti je drugi broj jednak nuli - {0}", br1 < 0 && br2 != 0);
        }
    }
}
