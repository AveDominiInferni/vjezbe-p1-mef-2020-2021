using System;

namespace _32.Zadatak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite proizvoljne rijeci odvojene jednom razmaknicom i bez tacke na kraju");
            string unos = Console.ReadLine();
            string[] rijeci = unos.Split(' ');
            string novaRecenica = "";


                foreach(string element in rijeci)
            {
                if (rijeci[0] == element)
                {
                    Console.Write(element.Substring(0, 1).ToUpper() + element.Substring(1, element.Length - 1).ToLower() + " ");
                }
                else if (element != rijeci[0] && element != rijeci[rijeci.Length - 1] )
                {
                    Console.Write(element.ToLower() + " ");
                }
                else
                {
                    Console.Write(element.ToLower() + ".");
                }
                
            }


           


        }
    }
}
