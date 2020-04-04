using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = 10;
            byte wiekUzytkownika = 31;

            string imieNazwisko = "Norbert Wieczorek";
            // ConsoleIn();
            StringExamples();
            Console.ReadKey();
        }
        static void ConsoleIn ()
        {
            Console.Write("Wprowadz wartosc:");
           string napis = Console.ReadLine();
            Console.WriteLine(napis);
            
        }
        static void Print(string napis)
        {
            Console.WriteLine(napis);
        }
        static void StringExamples()
        {
            string imieNazwisko = "Jan Kowalski";
            string lokalizacja1 = "c:\\prog\\tojest"; // escapowanie '\'
            string lokalizacja2 = @"c:\prog\cos"; // escapowanie '@'
            string slowo1 = "     Ala ma", slowo2 = "kota";
            string zdanie =  slowo1 +" " + slowo2;
            Print(zdanie);
            Print("Dlugosc zdania to: " + zdanie.Length.ToString() + " znakow");
            Print("Wielka litera: " + zdanie.ToUpper());
            Print("mala litera: " + zdanie.ToLower());
            Print("zmiana 'a' -> '*'" + zdanie.Replace('a', '*').Replace('A','*'));
            Print("trimowanie " + zdanie.Trim());
            Print("czy ten sam tekst ? " + zdanie.Trim().Equals("ala ma kota", StringComparison.OrdinalIgnoreCase));
            Print("czy zaczyna sie od kot?" + zdanie.StartsWith("kot"));
            string fraza = "ma";
            Print("pozycja wystapienie frazy '" + fraza + "'" + zdanie.Trim().IndexOf("ma"));
            zdanie = null;
            Print("czy pusty czy null?"+string.IsNullOrEmpty(zdanie));
            
        }
    }
}
