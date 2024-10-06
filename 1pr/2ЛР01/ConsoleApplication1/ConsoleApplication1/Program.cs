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
            Console.WriteLine("Лабораторная работа №1.Основы языка С#: Классы. Повторение");
            Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
            Console.WriteLine("В рамках курса \"Основы программирования\"");
            Console.WriteLine("Введите размерность пространства:");
            int n = Int32.Parse(Console.ReadLine());
            ArrayVector coordinates = new ArrayVector(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите значение {0}-й координаты", i + 1);
                int coord_value = Int32.Parse(Console.ReadLine());
                coordinates.SetElement(i,coord_value);
            }
            Console.Clear();
            bool key = true;
            string switcher;
            while (key)
            {
                Console.WriteLine("Заданный вектор: ");
                coordinates.Print();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1.Узнать значение определенной координаты.");
                Console.WriteLine("2.Изменить значение определенного элемента.");
                Console.WriteLine("3.Узнать длину вектора.");
                Console.WriteLine("4.Сумма всех положительных элементов массива с четными номерами.");
                Console.WriteLine("5.Сумма элеметов с нечетными номерами и меньше среднего значения всех модулей.");
                Console.WriteLine("6.Произведение всех четных положительных элементов.");
                Console.WriteLine("7.Произведение всех нечетных элементов не делящихся на 3.");
                Console.WriteLine("8.Сортировка по возрастанию.");
                Console.WriteLine("9.Сортировка по убыванию.");
                Console.WriteLine("10.Статические методы.");
                Console.WriteLine("0.Выход");
                switcher = Console.ReadLine();
                switch (switcher)
                {
                    case "1":
                        {
                            Console.WriteLine("Введите требуемый номер координаты вектора:");
                            int number = Int32.Parse(Console.ReadLine());
                            coordinates.GetElement(number - 1);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите номер элемента, который хотите изменить:");
                            int number = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите новое значение");
                            int element = Int32.Parse(Console.ReadLine());
                            coordinates.SetElement(number-1, element);
                            Console.WriteLine("Полученный вектор:");
                            coordinates.Print();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Длина заданного вектора: {0}", coordinates.GetNorm());
                            break;
                        }
                    case "4":
                        {
                            if (coordinates.SumPositives() == -1)
                            {
                                Console.WriteLine("Таких значений нет");
                            }
                            else
                            {
                                Console.WriteLine("Искомая сумма: {0}", coordinates.SumPositives());
                            }
                            break;
                        }
                    case "5":
                        {
                            int sum_less;
                            if (Int32.TryParse(coordinates.SumLess(), out sum_less))
                            {
                                Console.WriteLine("Искомая сумма: {0}", sum_less);
                            }
                            else
                            {
                                Console.WriteLine("Таких значений нет.");
                            }
                            break;
                        }
                    case "6":
                        {
                            if (coordinates.MultEven() == 1)
                            {
                                Console.WriteLine("Таких значений нет.");
                            }
                            else
                            {
                                Console.WriteLine("Искомое произведение: {0}", coordinates.MultEven());
                            }
                            break;
                        }
                     case "7":
                        {
                            int mult_odd;
                            if (Int32.TryParse(coordinates.MultOdd(), out mult_odd))
                            {
                                Console.WriteLine("Искомое произведение: {0}", mult_odd);
                            }
                            else
                            {
                                Console.WriteLine("Таких значений нет.");
                            }
                            break;
                        }
                     case "8":
                        {
                            Console.WriteLine("Начальный вектор:");
                            coordinates.Print();
                            coordinates.SortUp();
                            Console.WriteLine("Отсортированный по возрастанию вектор:");
                            coordinates.Print();
                            break;
                        }
                     case "9":
                        {
                            Console.WriteLine("Начальный вектор:");
                            coordinates.Print();
                            coordinates.SortDown();
                            Console.WriteLine("Отсортированный по убыванию вектор:");
                            coordinates.Print();
                            break;
                        }
                     case "10":
                        {
                            Console.WriteLine("1.Сумма.");
                            Console.WriteLine("2.Скалярное произведение.");
                            Console.WriteLine("3.Умножение на число.");
                            Console.WriteLine("4.Длина вектора.");
                            string switcher2 = Console.ReadLine();
                            switch (switcher2)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("Введите размерность 2-ого вектора:");
                                        int n1 = Int32.Parse(Console.ReadLine());
                                        ArrayVector vector1 = new ArrayVector(n1);
                                        for (int i = 0; i < n1; i++)
                                        {
                                            Console.WriteLine("Введите значение {0}-й координаты", i + 1);
                                            int coord_value1 = Int32.Parse(Console.ReadLine());
                                            vector1.SetElement(i, coord_value1);
                                        }
                                        ArrayVector vector2 = Vectors.Sum(coordinates, vector1);
                                        Console.WriteLine("Полученный вектор:");

                                        vector2.Print();
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine("Введите размерность 2-ого вектора:");
                                        int n1 = Int32.Parse(Console.ReadLine());
                                        ArrayVector vector1 = new ArrayVector(n1);
                                        for (int i = 0; i < n1; i++)
                                        {
                                            Console.WriteLine("Введите значение {0}-й координаты", i + 1);
                                            int coord_value2 = Int32.Parse(Console.ReadLine());
                                            vector1.SetElement(i, coord_value2);
                                        }
                                        double scalar = Vectors.Scalar(coordinates, vector1);
                                        Console.WriteLine("Скалярное произведение векторов: {0}", scalar);
                                        break;
                                    }
                                case "3":
                                    {
                                        Console.WriteLine("Введите число на которое необходимо умножить:");
                                        int mult = Int32.Parse(Console.ReadLine());
                                        ArrayVector vector1 = Vectors.Mult(coordinates, mult);
                                        Console.WriteLine("Полученный вектор:");
                                        vector1.Print();
                                        break;
                                    }
                                case "4":
                                    {
                                        double norm = Vectors.Norm(coordinates);
                                        Console.WriteLine("Длина вектора: {0}", norm);
                                        break;
                                    }
                            }
                            break;
                        }
                     case "0":
                        {
                            key = false;
                            break;
                        }
                }
            }
        }
    }
}
