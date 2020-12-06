using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite koordinate tacke A");
            Console.Write("xA = ");
            double xA = Convert.ToDouble(Console.ReadLine());
            Console.Write("yA = ");
            double yA = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nTacka A({0};{1}) se nalazi ", xA, yA);
            if (xA > 0 && yA > 0)
                Console.Write("u I kvadrantu.");
            else if (xA < 0 && yA > 0)
                Console.Write("u II kvadrantu.");
            else if (xA < 0 && yA < 0)
                Console.Write("u III kvadrantu.");
            else if (xA > 0 && yA < 0)
                Console.Write("u IV kvadrantu.");
            else if (xA == 0 && yA != 0)
                Console.Write("na y osi.");
            else if (xA != 0 && yA == 0)
                Console.Write("na x osi.");
            else
                Console.Write("na u koordinatnom pocetku.");
        }
    }
}
