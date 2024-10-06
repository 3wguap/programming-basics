using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите координату x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y: ");
            y = Convert.ToDouble(Console.ReadLine());
            if ((y >= Math.Pow(x - 2, 2) - 3) && ((y <= x && y >= 0) || y <= -x))
                Console.WriteLine("Вы попали в мишень");
            else
                Console.WriteLine("Вы не попали в мишень");
            Console.ReadLine();
        }
    }
}
