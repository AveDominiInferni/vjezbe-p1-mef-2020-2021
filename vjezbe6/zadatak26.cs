using System;

namespace _26.Zadatak
{
    class Program
    {
        static void Main()
        {
            string tekst = "komPJUterske sIMUlaCIJE nEKiH vREMenski oVISnih ProBleMa inžinjerske fIZIKe";
            string[] niz = tekst.Split(" ");
            string tekst2 = "";
            foreach(var element in niz)
            {
                tekst2 = tekst2 + element.Substring(0, 1).ToUpper() + element.Substring(1, element.Length - 1).ToLower() + " "; 
            }
            Console.WriteLine(tekst2);
            Console.ReadKey();


        }
    }
}
