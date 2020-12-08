using System;
using System.IO;

namespace Vjezbe_7
{
	static class Zadatak_8
	{
        public static void Main()
        {
            StreamWriter SW = new StreamWriter("brojevi.txt");

            Console.Write("Unesite broj vašeg indexa: ");
            string index = Console.ReadLine();
            for(int i = 0; i < index.Length - 1; i++)
            {
                SW.Write(index[i] + " ");
            }
            SW.Write(index[index.Length - 1]);
            SW.Write("\n");
            for (int i2 = 0; i2 < index.Length - 1; i2++)
            {
                SW.Write($"{index[i2]}0 ");
            }
            SW.Write($"{index[index.Length - 1]}0");
            SW.Write("\n");
            string[] neki = new string[index.Length];
            Console.WriteLine();
            for(int i3 = 0; i3 < index.Length; i3++)
            {
                Console.Write("Unos 1: ");
                neki[i3] = Console.ReadLine(); 
            }
            Console.WriteLine();
            foreach (var element in neki)
            {
                SW.Write(element + " ");
            }
            SW.Close();
            StreamReader CC = new StreamReader("brojevi.txt");
            string kada = CC.ReadToEnd();
            Console.WriteLine(kada);


        }
	}
}