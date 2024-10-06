using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите координату x: ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < -7 || x > 3)
            {
                Console.WriteLine("При данном значении x функция не определена.");
            }
            else
            {
                if (x < -6)
                    y = 2;
                else if (x < -2)
                    y = 0.25 * x + 0.5;
                else if (x < 0) 
                    y = 2 - Math.Sqrt(-Math.Pow(x, 2) - 4 * x);
                else if (x < 2)
                    y = Math.Sqrt(4 - Math.Pow(x, 2));
                else
                    y = -x + 2;
                Console.WriteLine("Значение функции в точке x равно {0:0.000}", y);
            }
            Console.ReadLine();
        }
    }
}
