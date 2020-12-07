using System;
using System.Collections.Generic;

namespace vjezbe5
{ 
    class zadatak
    {
        static void IspisNiza(double[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i]);
                if (i != niz.Length - 1) Console.Write(", ");
            }
            Console.Write("\n");
        }
        static void IspisListe(List<double> lista, ConsoleColor boja)
        {
            Console.ForegroundColor = boja;
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + "  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n");
        }
        static List<double> VratiKolekcijuURasponu(double[] niz, double min, double max)
        {
            List<double> lista = new List<double>();
            for (int i = 0; i < niz.Length; i++)
                if (niz[i] >= min && niz[i] < max)
                    lista.Add(niz[i]);
            return lista;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double min = -20, max = 45;

            double[] niz = new double[50];
            for (int i = 0; i < 50; i++)
                niz[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
            List<double> vnt = VratiKolekcijuURasponu(niz, -20, -5);
            List<double> nt = VratiKolekcijuURasponu(niz, -5, 10);
            List<double> st = VratiKolekcijuURasponu(niz, 20, 25);
            List<double> vt = VratiKolekcijuURasponu(niz, 25, 35);
            List<double> vvt = VratiKolekcijuURasponu(niz, 35, 45);
            Console.WriteLine("Vrijednosti 50 izmjerenih temperatura:\n");
            IspisNiza(niz);
            Console.WriteLine("\n" + new String('=', 100));
            Console.WriteLine("\nGrupa veoma niskih temperatura (-20 ÷ -5) stepeni Celzijusa. Ima ukupno {0} elemenata:\n", vnt.Count);
            IspisListe(vnt, ConsoleColor.Blue);
            Console.WriteLine("\nGrupa niskih temperatura (-5 ÷ 10) stepeni Celzijusa. Ima ukupno {0} elemenata:\n", nt.Count);
            IspisListe(nt, ConsoleColor.Cyan);
            Console.WriteLine("\nGrupa srednjih temperatura (10 ÷ 25) stepeni Celzijusa. Ima ukupno {0} elemenata:\n", st.Count);
            IspisListe(st, ConsoleColor.Green);
            Console.WriteLine("\nGrupa visokih temperatura (25 ÷ 35) stepeni Celzijusa. Ima ukupno {0} elemenata:\n", vt.Count);
            IspisListe(vt, ConsoleColor.Yellow);
            Console.WriteLine("\nGrupa veoma visokih temperatura (35 ÷ 45) stepeni Celzijusa. Ima ukupno {0} elemenata:\n", vvt.Count);
            IspisListe(vvt, ConsoleColor.Red);
            Console.WriteLine(new String('=', 100));
        }
    }
}