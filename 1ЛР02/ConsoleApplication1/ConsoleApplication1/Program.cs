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
            int verificator = 1, key;
            while (verificator == 1)
            {
                Console.WriteLine("Лабораторная работа №2.Основы языка С#: Программы с использованием циклов");
                Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
                Console.WriteLine("В рамках курса \"Основы программирования\"");
                Console.WriteLine("Номер 1 - Таблица значений функции");
                Console.WriteLine("Номер 2 - Серия выстрелов по мишени");
                Console.WriteLine("Номер 3 - Сумма ряда");
                Console.WriteLine("Введите номер задания:");
                key = Int32.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            double xmin, xmax, dx, y;
                            int verificator2 = 1;
                            while (verificator2 == 1)
                            {
                                Console.WriteLine("Введите левую границу отрезка: ");
                                xmin = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите правую границу отрезка: ");
                                xmax = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите шаг: ");
                                dx = Double.Parse(Console.ReadLine());
                                Console.WriteLine("\t\tx\t\t     y");
                                for (double x = xmin; x <= xmax; x += dx)
                                {
                                    if ((x < -7) || (x > 3))
                                    {
                                        Console.WriteLine("\t{0,10:0.0}\t             -", x);
                                    }
                                    else
                                    {
                                        if (x < -6)
                                        {
                                            y = 2;
                                            Console.WriteLine("\t{0,10:0.0} \t{1,16:0.00}", x, y);
                                        }
                                        else if (x < -2)
                                        {
                                            y = 0.25 * x + 0.5;
                                            Console.WriteLine("\t{0,10:0.0}\t{1,16:0.00}", x, y);
                                        }
                                        else if (x < 0)
                                        {
                                            y = 2 - Math.Sqrt(4 - (x + 2) * (x + 2));
                                            Console.WriteLine("\t{0,10:0.0}\t{1,16:0.00}", x, y);
                                        }
                                        else if (x < 2)
                                        {
                                            y = Math.Sqrt(4 - x * x);
                                            Console.WriteLine("\t{0,10:0.0}\t{1,16:0.00}", x, y);
                                        }
                                        else
                                        {
                                            y = -x + 2;
                                            Console.WriteLine("\t{0,10:0.0}\t{1,16:0.00}", x, y);
                                        }
                                    }
                                }

                                Console.WriteLine("Хотите продолжить это задание? 1 - Да, Другое число - Нет");
                                verificator2 = Int32.Parse(Console.ReadLine());
                            }
                            break;
                        }
                    case 2:
                        {
                            double x, y;
                            int verificator2 = 1;
                            while (verificator2 == 1)
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine("Введите координату x: ");
                                    x = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите координату y: ");
                                    y = Double.Parse(Console.ReadLine());
                                    if ((y >= Math.Pow(x - 2, 2) - 3) && (y <= -x) || (y >= Math.Pow(x - 2, 2) - 3) && (Math.Abs(y) <= x) && (y >= 0))
                                    {
                                        Console.WriteLine("Точка попадает в мишень ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Точка не попадает в мишень");
                                    }
                                }
                                Console.WriteLine("Хотите продолжить это задание? 1 - Да, Другое число - Нет");
                                verificator2 = Int32.Parse(Console.ReadLine());
                            }
                            break;
                        }
                    case 3:
                        {
                            double e, k = 1, x, arctg = Math.PI / 2;
                            int n = 0, verificator2 = 1;
                            while (verificator2 == 1)
                            {
                                Console.WriteLine("Введите x: ");
                                x = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите точность e: ");
                                e = Double.Parse(Console.ReadLine());
                                if (x <= 1)
                                {
                                    Console.WriteLine("Введено некорректное значение x. Введите значение x больше 1.");
                                }
                                else
                                {
                                    if (e < 0)
                                    {
                                        Console.WriteLine("Введено некорректное значение e. Введите значение e больше 0.");
                                    }
                                    else
                                    {
                                        do
                                        {
                                            k = Math.Pow((-1), n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                                            arctg += k;
                                            n++;
                                        } while (Math.Abs(k) > e);
                                        Console.WriteLine("Сумма ряда: " + arctg);
                                        Console.WriteLine("Количество членов в ряду: " + (n-1));
                                    }
                                }
                                Console.WriteLine("Хотите продолжить это задание? 1 - Да, Другое число - Нет");
                                verificator2 = Int32.Parse(Console.ReadLine());
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введен некорректный номер задания.");
                            break;
                        }
                }
                Console.WriteLine("Хотите продолжить? 1 - Да, Другое число - Нет");
                verificator = Int32.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
