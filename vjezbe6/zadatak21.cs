using System;

namespace _2._5_Zadatak_21_
{
    class Program
    {
        static void Main()
        {
            string recenica = "pOCeTak rEceNiCE...";

            string novaRecenica1 = recenica.Substring(0, 1).ToUpper() + recenica.Substring(1, recenica.Length - 1).ToLower();
            Console.WriteLine($"Stara recenica {recenica}");
            Console.WriteLine($"Nova recenica {novaRecenica1}");
        }

    }
}