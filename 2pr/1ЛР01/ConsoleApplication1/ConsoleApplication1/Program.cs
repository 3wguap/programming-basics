using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, a;
            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());
            z2 = (4 - Math.Pow(a, 2)) / 2;
            if (2*a+Math.Pow(a,2) != 0 && 2*a-Math.Pow(a,2) != 0)
            {
                z1 = Math.Pow((1 + a + Math.Pow(a, 2)) / (2 * a + Math.Pow(a, 2)) + 2 - ((1 - a + Math.Pow(a, 2)) / (2 * a - Math.Pow(a, 2))), -1) * (5 - 2 * Math.Pow(a, 2));
                Console.WriteLine("Значение первой дроби: {0:0.000}, значение второй дроби: {1:0.000}", z1, z2);
            }
            else
                Console.WriteLine("Значение знаменателя первой дроби равно 0 \nВторая дробь равна: {0:0.000}", z2);
            Console.ReadLine();
        }
    }
}
