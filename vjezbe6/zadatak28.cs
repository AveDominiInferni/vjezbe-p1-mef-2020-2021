using System;

namespace _28.Zadatak
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite niz cijelih brojeva odvojenih jednim zarezom:");
           string unos = Console.ReadLine();

            string[] brojevi = unos.Split(',');
            string jednocifreni = "";
            foreach(var element in brojevi)
            {
               if ((int.Parse(element) / 10) == 0 )
                {
                    jednocifreni += element + " ";
                }
            }

            Console.WriteLine(jednocifreni);


        }
    }
}
