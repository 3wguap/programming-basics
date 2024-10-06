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
            Console.WriteLine("Лабораторная работа №4.Основы языка С#: Простейшие классы");
            Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
            Console.WriteLine("В рамках курса \"Основы программирования\"");
            bool verifier0 = true;
            while (verifier0)
            {
                Console.WriteLine("Задания:");
                Console.WriteLine("1.Счетчик");
                Console.WriteLine("2.Многочлен");
                Console.WriteLine("0.Выход");
                string choice1 = Console.ReadLine();
                switch (choice1)
                {
                    case "1":
                        {
                            string verifier1 = "1";
                            while (verifier1 == "1")
                            {
                                int min, max, curr;
                                string choice2;
                                Console.WriteLine("Введите минимальное значение для счетчика");
                                min = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите максимальное значение для счетчика");
                                max = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите начальное значение счетчика");
                                curr = Int32.Parse(Console.ReadLine());
                                Counter count = new Counter(min, max, curr);
                                bool verifier2 = true;
                                while (verifier2)
                                {
                                    Console.WriteLine("Выберите действие:");
                                    Console.WriteLine("1.Увеличить счетчик на 1");
                                    Console.WriteLine("2.Уменьшить счетчик на 1");
                                    Console.WriteLine("3.Показать значение счетчика");
                                    Console.WriteLine("0.Выход из задания");
                                    choice2 = Console.ReadLine();
                                    switch (choice2)
                                    {
                                        case "1":
                                            {
                                                count.Increaser();
                                                count.Currentness();
                                                break;
                                            }
                                        case "2":
                                            {
                                                count.Decreaser();
                                                count.Currentness();
                                                break;
                                            }
                                        case "3":
                                            {
                                                count.Currentness();
                                                break;
                                            }
                                        case "0":
                                            {
                                                verifier2 = false;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Ошибка.Повторите ввод.");
                                                break;

                                            }

                                    }

                                }
                                Console.WriteLine("Хотите повторить номер? 1 - да, любое число-нет.");
                                verifier1 = Console.ReadLine();
                            }
                            break;
                        }
                    case "2":
                        {
                            string verifier2 ="1";
                            while (verifier2 == "1")
                            {
                                Console.WriteLine("Введите значение коэффициэнта a");
                                double a = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите значение коэффициэнта b");
                                double b = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите значение коэффициэнта c");
                                double c = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Ваш многочлен:\n {0} * x^2 + {1} * x + {2} = 0",a,b,c);
                                Polynom pol = new Polynom(a, b, c);
                                pol.Solution();
                                Console.WriteLine("Хотите повторить номер? 1 - да, любое число-нет.");
                                verifier2 =Console.ReadLine();
                            }
                            break;
                        }
                    case "0":
                        {
                            verifier0 = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ввод некорректен.Повторите ввод. \n");
                            break;
                        }
                }
            }
        }
    }
}
