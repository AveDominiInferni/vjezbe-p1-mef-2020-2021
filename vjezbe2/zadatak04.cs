using System;

namespace vjezbe2
{ 
    class zadatak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan realan broj i jedan pozitivan cijeli broj:");
            string unos1, unos2;
            unos1 = Console.ReadLine();
            unos2 = Console.ReadLine();
            double realan_broj;
            uint pozitivan_cijeli_broj;
            Console.WriteLine("\nKorisnik je unio realan broj - {0}", double.TryParse(unos1, out realan_broj));
            Console.WriteLine("Korisnik je unio pozitivan cijeli broj - {0}", uint.TryParse(unos2, out pozitivan_cijeli_broj));
            Console.WriteLine("Korisnik je unio i realan i pozitivan cijeli broj - {0}", double.TryParse(unos1, out realan_broj) && uint.TryParse(unos2, out pozitivan_cijeli_broj));
        }
    }
}
