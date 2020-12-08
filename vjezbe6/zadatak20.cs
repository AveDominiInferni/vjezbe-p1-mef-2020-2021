using System;

namespace _20.Zadatak
{
    class Program
    {
        static void Main()
        {
            string tekst = "Programiranje 1";
            Console.WriteLine(tekst.Substring(3, 4));

            string tekst2 = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if (i >= 3 && i <=6)
                {
                    Console.Write(tekst[i]);
                }


            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
