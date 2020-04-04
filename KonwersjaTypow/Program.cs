using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = 10;
            byte zmienna2 = 5;
            zmienna1 = zmienna2;
            zmienna2 = (byte)zmienna1;
            Console.WriteLine("zmienna1= " +zmienna1+" zmienna2= "+ zmienna2);
            Console.ReadKey();
            zmienna1 = 123456;
            zmienna2 = (byte)zmienna1;
            double wartosc1 = -12345.45;
            int wartosc2 = (int)wartosc1;
            string napis = wartosc1.ToString();

            wartosc2 = Convert.ToInt32(wartosc1);
            Console.WriteLine(wartosc2);

        }
    }
}
