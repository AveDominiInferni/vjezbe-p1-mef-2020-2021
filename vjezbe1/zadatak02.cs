using System;

namespace vjezbe1
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            double var1 = 1.6180339887498948482045868343656381177;
            float var2 = 1.6180339887498948482045868343656381177F;
            decimal var3 = 1.6180339887498948482045868343656381177M;
            Console.WriteLine("Preciznost decimalnih tipova podataka:\n\tdouble ---> PHI = {0}\n\tfloat--->PHI = {1}\n\tdecimal ---> PHI = {2}", var1, var2, var3);
        }
    }
