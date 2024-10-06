using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Polynom
    {
        public double a;
        public double b;
        public double c;
        public Polynom(double a1,double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public void Solution()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Корней бесконечно много");
                    else
                        Console.WriteLine("Корней нет");
                }
                else
                    Console.WriteLine("Один корень: {0}", -c/b);
            }
            else if (b == 0)
            {
                if (-c / a < 0)
                    Console.WriteLine("Корней  нет");
                else
                    Console.WriteLine("Один корень: {0}", Math.Sqrt(-c/a));
            }
            else
            {
                if (Math.Pow(b, 2) - 4 * a * c < 0)
                    Console.WriteLine("Корней  нет");
                else if (Math.Pow(b, 2) - 4 * a * c == 0)
                    Console.WriteLine("Один  корень: {0}", -b / (2 * a));
                else
                    Console.WriteLine("Два корня: {0}\t{1}", (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a), (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
            }
        }
    }
}
