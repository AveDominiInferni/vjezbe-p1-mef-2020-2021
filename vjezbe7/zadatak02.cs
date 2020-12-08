using System;
using System.IO;

namespace _5.Zadatak
{
    class Program
    {
        static void Main()
        {
            StreamWriter muha = new StreamWriter("test1234.txt");
            Console.WriteLine(61);
            Console.WriteLine(2.5);
            Console.WriteLine($"{2.5} + {1.3} = {Math.Round(2.5 + 1.3, 2)}");
            Console.WriteLine("FeliPe PENA");            
            Console.WriteLine(true + ".");
            muha.Close();
            

            StreamReader fsr = new StreamReader("test1234.txt");
                     
            Console.WriteLine(fsr.ReadToEnd());
            
            fsr.Close();
            Console.ReadKey();



        }
    }
}
