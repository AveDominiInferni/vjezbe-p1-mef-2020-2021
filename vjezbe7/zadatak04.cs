using System;
using System.Collections.Generic;
using System.IO;
namespace _7.Zadatak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadatak 7");
            StreamReader kupus = new StreamReader("test123.txt");
            string PrviRed = kupus.ReadLine();
            int broj = int.Parse(PrviRed) * 5;
            Console.WriteLine(broj);
            string drugiRed = kupus.ReadLine();
            string TreciRed = kupus.ReadLine();
            Console.WriteLine(TreciRed);
            string cetvrtiRed = kupus.ReadLine();
            string[] nizStr = cetvrtiRed.Split(' ');
            List<string> listaStr = new List<string>();
            foreach (string rijec in nizStr)
            {
                listaStr.Add(rijec.Substring(0, 1).ToUpper() + rijec.Substring(1, rijec.Length - 1).ToLower());
            }
            Console.WriteLine(string.Join(" ", listaStr));
            string petiRed = kupus.ReadLine();
            Console.WriteLine(petiRed.Substring(0, petiRed.Length - 1));

            Console.ReadKey();



        }
    }
}
