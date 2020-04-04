using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int a;
                int b;
                int wynik=0;
                Console.Write("podaj pierwsza liczbe:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("podaj znak operacji(esc konczy program :");
                ConsoleKeyInfo operacja = Console.ReadKey();
                if (operacja.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("koniec");
                    break;
                }
                Console.WriteLine();
                Console.Write("podaj druga liczbe");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 0 && operacja.Key == ConsoleKey.Divide)
                {
                    Console.WriteLine("nie dziel przez zero");
                    continue;
                }
                Console.WriteLine();
                switch (operacja.Key)
                {
                    case ConsoleKey.Add:
                        {
                            wynik = a + b;
                            Console.WriteLine("wynik to : " + wynik);
                            break;
                        }

                    case ConsoleKey.Subtract:
                        {
                            wynik = a - b;
                            Console.WriteLine("wynik to : " + wynik);
                            break;
                        }


                    case ConsoleKey.Multiply:
                        {
                            Console.WriteLine("wynik to : " + wynik);
                            wynik = a * b;
                            break;
                        }


                    case ConsoleKey.Divide:
                        {
                            wynik = a / b;
                            Console.WriteLine("wynik to : " + wynik);
                            break;
                        }

                    default:
                        Console.WriteLine("bledna operacja");
                        break;
                }
            } while (true);

        }
    }
}
