using System;

namespace vjezbe3
{ 
    class zadatak
    {
        static void UnosIProvjeraPolozajaTackeURavni()
        {
            Console.WriteLine("Unesite naziv tacke ciji polozaj u ravni provjeravate:");
            string oznaka = Console.ReadLine();
            Console.WriteLine("Unesite koordinate tacke {0}:", oznaka);
            Console.Write("x{0} = ", oznaka);
            double xA = Convert.ToDouble(Console.ReadLine());
            Console.Write("y{0} = ", oznaka);
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
            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            UnosIProvjeraPolozajaTackeURavni();
            UnosIProvjeraPolozajaTackeURavni();
            UnosIProvjeraPolozajaTackeURavni();
        }
    }
}
