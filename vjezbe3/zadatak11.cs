using System;
using System.Collections.Generic;

namespace vjezbe3
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tri realna broja:");
            double br1 = Convert.ToDouble(Console.ReadLine());
            double br2 = Convert.ToDouble(Console.ReadLine());
            double br3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nUneseni brojevi sortirani od najmanjeg do najveceg:");
            List<double> lista = new List<double>();
            lista.Add(br1);
            lista.Add(br2);
            lista.Add(br3);
            lista.Sort();
            foreach (double x in lista) 
                Console.Write(x + " ");
        }
    }
}
