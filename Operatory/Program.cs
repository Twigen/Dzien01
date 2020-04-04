using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatoryArytmetyczne();
            OperatoryRelacyjne();
            Console.ReadKey();
        }
        static void OperatoryRelacyjne()
        {
            double x = 987, y = 12345.6789;
            Print("x= " + x + "y= " + y);
            Print((x == y).ToString());
            Print((x != y).ToString());
            Print((x > y).ToString());
            Print((x >= y).ToString());
            Print((x < y).ToString());
            Print((x <= y).ToString());
           
        }
        static void OperatoryPrzypisania()
        {
            Int64 a = 4374364, b = 483900912, c = -102399419;
            c = a;
            c += a;
            c -= a;
            c *= a;
            c /= a;
            c %= a; // c = c % a;
            c >>= 2; // c = c >> 2;
            c <<= 2; c = c << 2;
        }

        static void OperatoryLogiczne()
        {
            bool a = false, b = true;
            bool c;
            c = a && b;
            c = a || b;
            c = !a;
            c = ((!b)
        }
        static void OperatoryArytmetyczne ()
        {
            double x = 12345.555, y = 1234.43;
            double z;
            z = x + y;
            Print(z.ToString());
            z = x - y;
            Print(z.ToString());
            z = x * y;
            Print(z.ToString());
            z = x / y;
            Print(z.ToString());
            z = x % y;
            Print(z.ToString());
            int a = 10;
            a++;
            a--;
            Print((a++).ToString());
            a--;
            Print((++a).ToString());
        }
        static void Print(string napis)
        {
            Console.WriteLine(napis);
        }
    }
}
