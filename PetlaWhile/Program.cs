using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 10;
            while (licznik > 0 )
            {
                Console.WriteLine(licznik);
                licznik--;
            }
            Console.WriteLine();
            do
            {
                Console.WriteLine(licznik);
                licznik--;
            } while (licznik>0);

            while (true)
            {
                Console.WriteLine("podaj liczbe wieksza od 100 i podzielna przez 2");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if(liczba > 100 && liczba%2==0)
                {
                    Console.WriteLine("podano poprawna liczbe");
                    break;
                }
                else
                {
                    Console.WriteLine("podaj poprawna liczbe");
                }
            }
        }
    }
}
