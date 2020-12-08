using System;

namespace _2._9_Zadatak_31_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite proizvoljan tekst:");
            string tekst = Console.ReadLine();

            string novitekst = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst.Substring(i, 1) == "a" || tekst.Substring(i, 1) == "A")
                    novitekst += 5;
                else if (tekst.Substring(i, 1) == "o" || tekst.Substring(i, 1) == "O")
                    novitekst += 8;
                else
                    novitekst += tekst[i];

            }

            Console.WriteLine(novitekst);
        }

    }
}