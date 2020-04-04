using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaWarunkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int wiek = 24;
            bool czyObywatelPolski = false;
            if (czyObywatelPolski)
            {


                if (wiek >= 35)
                {
                    Console.WriteLine("mozesz na prezydenta");
                }
                else if (wiek >= 30)
                {
                    Console.WriteLine("mozesz na senatora");
                }
                else if (wiek >=21)
                {
                    Console.WriteLine("mozesz na posla");
                }
                else if (wiek >=18)
                {
                    Console.WriteLine("mozesz glosowac");
                }
                else
                {
                    Console.WriteLine("jestes niepelnoletni");
                }
            }
            else
            {
                Console.WriteLine("nie jestes obywatelem polski");
            }*/
            SwitchCase();
            Console.ReadKey();
        }
        static void SwitchCase()
        {
            Console.WriteLine("podaj ocene od 1 do 6");
            int ocena = Convert.ToInt32( Console.ReadLine());
            switch (ocena)
            { case 1:
                    Console.WriteLine("niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("dop");
                    break;
                case 3:
                    Console.WriteLine("dst");
                    break;
                case 4:
                    Console.WriteLine("db");
                    break;
                case 5:
                    Console.WriteLine("bdb");
                    break;
                case 6:
                    Console.WriteLine("cel");
                    break;
                default:
                    Console.WriteLine("nie znam takiej oceny" + ocena);
                    break;
            }
        }
    }
}
