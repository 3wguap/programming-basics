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
            Console.WriteLine("Лабораторная работа №5.Основы языка С#: Массивы");
            Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
            Console.WriteLine("В рамках курса \"Основы программирования\"");
            bool verifier0 = true;
            while (verifier0)
            {
                Console.WriteLine("Задания:");
                Console.WriteLine("1.Сортировка");
                Console.WriteLine("2.Массивы");
                Console.WriteLine("3.Ступенчатые массивы");
                Console.WriteLine("0.Выход");
                string choice0 = Console.ReadLine();
                switch (choice0)
                {
                    case "1":
                        {
                            string verifier1 = "1";
                            while (verifier1 == "1")
                            {
                                Console.WriteLine("Введите длину массива:");
                                int k = Int32.Parse(Console.ReadLine());
                                Sort myarr = new Sort(k);
                                myarr.Input();
                                myarr.Output();
                                Console.WriteLine("Выберите метод сортировки:");
                                Console.WriteLine("1.Сортировка пузырьком");
                                Console.WriteLine("2.Гномья сортировка");
                                Console.WriteLine("3.Шейкерная сортировка");
                                string choice1 = Console.ReadLine();
                                switch (choice1)
                                {
                                    case "1":
                                        {
                                            myarr.Bubble();
                                            myarr.Output();
                                            break;
                                        }
                                    case "2":
                                        {
                                            myarr.Gnome();
                                            myarr.Output();
                                            break;
                                        }
                                    case "3":
                                        {
                                            myarr.Shaker();
                                            myarr.Output();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Ввод некорректен.Повторите ввод.");
                                            break;
                                        }
                                }
                                Console.WriteLine("Хотите повторить? 1 - да, любое число - нет.");
                                verifier1 = Console.ReadLine();
                            }
                            break;
                        }
                    case "2":
                        {
                            string verifier2 = "1";
                            while (verifier2 == "1")
                            {
                                Console.WriteLine("Введите количество строк массива:");
                                int m = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите количество столбцов массива:");
                                int n = Int32.Parse(Console.ReadLine());
                                Myarr twodim = new Myarr(m, n);
                                twodim.Filler();
                                twodim.Output();
                                Console.WriteLine("Сортировка столбцов по возрастанию:");
                                twodim.Sortinc();
                                twodim.Output();
                                Console.WriteLine("Сортировка столбцов по убыванию:");
                                twodim.Sortdec();
                                twodim.Output();
                                Console.WriteLine("Хотите повторить? 1 - да, любое число - нет.");
                                verifier2 = Console.ReadLine();
                            }
                            break;
                        }
                    case "3":
                        {
                            string verifier3 = "1";
                            while (verifier3 == "1")
                            {
                                Console.WriteLine("Введите количество строк массива:");
                                int m = Int32.Parse(Console.ReadLine());
                                int[] j = new int[m];
                                for (int i = 0; i < m; i++)
                                {
                                    Console.WriteLine("Введите количество элементов в {0} строке массива:", i + 1);
                                    j[i] = Int32.Parse(Console.ReadLine());
                                }
                                Stepped step = new Stepped(m, j);
                                step.Input();
                                step.Output();
                                step.Sort();
                                Console.WriteLine("Сортировка по возрастанию");
                                step.Output();
                                Console.WriteLine("Хотите повторить? 1 - да, любое число - нет.");
                                verifier3 = Console.ReadLine();
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
                            Console.WriteLine("Ввод некорректен.Повторите ввод.");
                            break;
                        }
                }
            }
        }
    }
}
