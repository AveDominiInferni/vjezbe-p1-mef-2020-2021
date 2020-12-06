using System;

namespace vjezbe2
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva pozitivna cijela broja:");
            int br1, br2;
            br1 = Convert.ToInt32(Console.ReadLine());
            br2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nRezultat dijeljenja brojeva {0} i {1} je {2}, a ostatake je {3}.", br1, br2, br1 / br2, br1 % br2);
        }
    }
}
