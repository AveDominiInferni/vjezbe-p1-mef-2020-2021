using System;
using System.IO;
namespace _6.Zadatak
{
    class Program
    {
        static void Main()
        {
            StreamReader muha = new StreamReader("test123.txt");

            string citavSadrzaj = muha.ReadToEnd();
            Console.WriteLine("Zadatak 6: ");
            Console.WriteLine(citavSadrzaj);
            Console.WriteLine();
            muha.Close();

        }
    }
}
