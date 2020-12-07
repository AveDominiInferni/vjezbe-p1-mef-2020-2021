using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void PolozajTackeUOdnosuNaKruznicu(double r, string naziv)
        {
            Console.WriteLine("\nUnesite x i y koordinate tacke {0}(x,y) i program ce provjeriti polozaj tacke {0}", naziv);
            Console.Write("Koordinata x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Koordinata y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            double d = Math.Sqrt(x * x + y * y);
            if (d < r)
                Console.WriteLine("\nTacka {3}({0};{1}) nalazi se unutar kruznice poluprecnika {2}.", x, y, r, naziv);
            else if (d > r)
                Console.WriteLine("\nTacka {3}({0};{1}) nalazi se izvan kruznice poluprecnika {2}.", x, y, r, naziv);
            else
                Console.WriteLine("\nTacka {3}({0};{1}) nalazi se na kruznici poluprecnika {2}.", x, y, r, naziv);
        }
        static void Main(string[] args)
        {
            Console.Write("Unijeti vrijednost poluprecnika kruznice r = ");
            double r = Convert.ToDouble(Console.ReadLine());
            PolozajTackeUOdnosuNaKruznicu(r, "T");
            PolozajTackeUOdnosuNaKruznicu(r, "E");
            PolozajTackeUOdnosuNaKruznicu(r, "A1");
        }
    }
}
