using System;

namespace vjezbe1
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opseg decimalnih tipova podataka:\n\tdouble od {0} do {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("\tfloat od {0} do {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("\tdecimal od {0} do {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
