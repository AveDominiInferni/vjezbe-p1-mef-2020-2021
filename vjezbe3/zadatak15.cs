using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.Write("Unijeti vrijednost poluprecnika kruznice r = ");
            double r = Convert.ToDouble(Console.ReadLine());
            if (r > 0)
            {
                Console.WriteLine("\nUnesite x i y koordinate tacke T(x,y) i program ce provjeriti polozaj tacke T");
                Console.Write("Koordinata x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Koordinata y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                double d = Math.Sqrt(x * x + y * y);
                if (d < r)
                    Console.WriteLine("\nTacka T({0};{1}) nalazi se unutar kruznice poluprecnika {2}.", x, y, r);
                else if (d > r)
                    Console.WriteLine("\nTacka T({0};{1}) nalazi se izvan kruznice poluprecnika {2}.", x, y, r);
                else
                    Console.WriteLine("\nTacka T({0};{1}) nalazi se na kruznici poluprecnika {2}.", x, y, r);
            }
            else
                Console.WriteLine("\nVrijednost poluprecnika mora biti pozitivna vrijednost!");
        }
    }
}
