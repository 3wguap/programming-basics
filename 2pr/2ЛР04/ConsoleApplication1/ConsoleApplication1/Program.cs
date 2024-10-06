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
            Console.WriteLine("Лабораторная работа №4.Основы языка С#: Полиморфизм. Наследование.");
            Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
            Console.WriteLine("В рамках курса \"Основы программирования\"");
            bool key = true;
            string switcher;
            while (key)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1.Класс вектор ArrayVector.");
                Console.WriteLine("2.Класс список LinkedList.");
                Console.WriteLine("3.Класс со статическими методами.");
                Console.WriteLine("0.Выход");
                switcher = Console.ReadLine();
                Console.Clear();
                switch (switcher)
                {
                    case "1":
                        {
                            bool key1 = true;
                            while (key1)
                            {
                                Console.WriteLine("Класс вектор ArrayVector.");
                                Console.WriteLine("Введите количество координат вектора:");
                                int n = Int32.Parse(Console.ReadLine());
                                ArrayVector vector = new ArrayVector(n);
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("Введите {0} координату:", i+1);
                                    vector[i] = Double.Parse(Console.ReadLine());
                                }
                                Console.Clear();
                                Console.WriteLine("Класс вектор ArrayVector.");
                                
                                Console.WriteLine(vector.ToString());
                                Console.WriteLine("Выберите необходимое действие:");
                                Console.WriteLine("1.Узнать значение определенного элемента.");
                                Console.WriteLine("2.Изменить значение определенного элемента.");
                                Console.WriteLine("3.Узнать длину вектора.");
                                Console.WriteLine("4.Узнать количество координат.");
                                Console.WriteLine("0.Выход.");
                                string switcher1 = Console.ReadLine();
                                Console.Clear();
                                switch (switcher1)
                                {
                                    case "1":
                                        {
                                            Console.WriteLine("Класс вектор ArrayVector.");
                                            Console.WriteLine(vector.ToString());
                                            try
                                            {
                                                Console.WriteLine("Значение какой координаты хотите узнать?");
                                                int num = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine("Значение {0} координаты : {1}", num, vector[num - 1]);
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Введен неверный индекс.");
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "2":
                                        {
                                            Console.WriteLine("Класс вектор ArrayVector.");
                                            Console.WriteLine(vector.ToString());
                                            try
                                            {
                                                Console.WriteLine("Какую координату хотите изменить?");
                                                int num = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine("Введите новое значение:");
                                                vector[num - 1] = Double.Parse(Console.ReadLine());
                                                Console.WriteLine("Ваш новый вектор: ");
                                                Console.WriteLine(vector.ToString());
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Введен неверный индекс.");
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.WriteLine("Класс вектор ArrayVector.");
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Длина вектора: {0}", vector.GetNorm());
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine("Класс вектор ArrayVector.");
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Количество координат вектора: {0}",vector.Length);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "0":
                                        {
                                            key1 = false;
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Такого действия нет.Повторите ввод.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "2":
                        {
                            bool key1 = true;
                            while (key1)
                            {
                                Console.WriteLine("Класс список LinkedList.");
                                Console.WriteLine("Введите количество координат вектора:");
                                int num = Int32.Parse(Console.ReadLine());
                                LinkedListVector vector = new LinkedListVector(num);
                                for (int i = 0; i < vector.Length; i++)
                                {
                                    Console.WriteLine("Введите значение {0} координаты:",i+1);
                                    vector[i] = Double.Parse(Console.ReadLine());
                                }
                                Console.Clear();
                                Console.WriteLine("Класс список LinkedList.");
                                Console.WriteLine(vector.ToString());
                                Console.WriteLine("Выберите необходимое действие:");
                                Console.WriteLine("1.Узнать элемент по номеру.");
                                Console.WriteLine("2.Заменить элемент по номеру.");
                                Console.WriteLine("3.Узнать длину вектора.");
                                Console.WriteLine("4.Узнать количество координат вектора");
                                Console.WriteLine("5.Добавить элемент.");
                                Console.WriteLine("6.Удалить Элемент.");
                                Console.WriteLine("0.Выход.");
                                string switcher2 = Console.ReadLine();
                                Console.Clear();
                                switch (switcher2)
                                {
                                    case "1":
                                        {
                                            try
                                            {
                                                Console.WriteLine(vector.ToString());
                                                Console.WriteLine("Какую координату хотите узнать?");
                                                int n = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine("{0} координата: {1}", n, vector[n-1]);
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Введен некорректный индекс.");
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "2":
                                        {
                                            try
                                            {
                                                Console.WriteLine(vector.ToString());
                                                Console.WriteLine("Какую координату хотите поменять?");
                                                int n = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine("Введите новое значение координаты:");
                                                vector[n-1] = Double.Parse(Console.ReadLine());
                                                Console.WriteLine(vector.ToString());
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Введен некорректный индекс.");
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Длина вектора: {0}", vector.GetNorm());
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Количество координат вектора: {0}", vector.Length);
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "5":
                                        {
                                            Console.WriteLine("Выберите куда выхотите добавить элемент:");
                                            Console.WriteLine("1.В начало.");
                                            Console.WriteLine("2.В конец.");
                                            Console.WriteLine("3.По индексу.");
                                            string value = Console.ReadLine();
                                            if (value == "1")
                                            {
                                                Console.WriteLine(vector.ToString());
                                                Console.WriteLine("Введите добавляемое значение:");
                                                double element = Double.Parse(Console.ReadLine());
                                                vector.AddTop(element);
                                                Console.WriteLine(vector.ToString());
                                            }
                                            else if (value == "2")
                                            {
                                                Console.WriteLine(vector.ToString());
                                                Console.WriteLine("Введите добавляемое значение:");
                                                double element = Double.Parse(Console.ReadLine());
                                                vector.AddEnd(element);
                                                Console.WriteLine(vector.ToString());
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    Console.WriteLine(vector.ToString());
                                                    Console.WriteLine("Введите добавляемое значение:");
                                                    double element = Double.Parse(Console.ReadLine());
                                                    Console.WriteLine("Введите индекс по которому его надо добавить:");
                                                    int ind = Int32.Parse(Console.ReadLine());
                                                    vector.AddInd(ind, element);
                                                    Console.WriteLine(vector.ToString());
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "6":
                                        {
                                            Console.WriteLine("Выберите откуда выхотите удалить элемент:");
                                            Console.WriteLine("1.Из начала.");
                                            Console.WriteLine("2.Из конца.");
                                            Console.WriteLine("3.По индексу.");
                                            string value = Console.ReadLine();
                                            if (value == "1")
                                            {
                                                Console.WriteLine(vector.ToString());
                                                vector.DeleteTop();
                                                Console.WriteLine(vector.ToString());
                                            }
                                            else if (value == "2")
                                            {
                                                Console.WriteLine(vector.ToString());
                                                vector.DeleteEnd();
                                                Console.WriteLine(vector.ToString());
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    Console.WriteLine(vector.ToString());
                                                    Console.WriteLine("Введите индекс по которому надо удалить значение:");
                                                    int ind = Int32.Parse(Console.ReadLine());
                                                    vector.DeleteInd(ind);
                                                    Console.WriteLine(vector.ToString());
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "0":
                                        {
                                            key1 = false;
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Такого пункта меню нет. Повторите ввод.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                }
                            }
                            break;
                        }


                    case "3":
                        {
                            bool key1 = true;
                            while (key1)
                            {
                                Console.WriteLine("Класс со статическими методами.");
                                Console.WriteLine("Статические методы:");
                                Console.WriteLine("1.Сумма.");
                                Console.WriteLine("2.Скалярное произведение.");
                                Console.WriteLine("3.Длина вектора.");
                                Console.WriteLine("0.Выход");
                                string switcher3 = Console.ReadLine();
                                Console.Clear();
                                switch (switcher3)
                                {
                                    case "1":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Класс со статическими методами.");
                                                Console.WriteLine("Введите количество координат первого вектора:");
                                                int num1 = Int32.Parse(Console.ReadLine());
                                                IVectorable vector1 = new ArrayVector(num1);
                                                for (int i = 0; i < num1; i++)
                                                {
                                                    Console.WriteLine("Введите {0} координату:", i + 1);
                                                    vector1[i] = Double.Parse(Console.ReadLine());
                                                }
                                                Console.WriteLine("Введите количество координат второго вектора:");
                                                int num2 = Int32.Parse(Console.ReadLine());
                                                IVectorable vector2 = new LinkedListVector(num2);
                                                for (int i = 0; i < num2; i++)
                                                {
                                                    Console.WriteLine("Введите {0} координату:", i + 1);
                                                    vector2[i] = Double.Parse(Console.ReadLine());
                                                }
                                                Console.Clear();
                                                Console.WriteLine("Ваш первый вектор типа Arrayvector: ");
                                                Console.WriteLine(vector1.ToString());
                                                Console.WriteLine("Ваш второй вектор типа LinkedListVector: ");
                                                Console.WriteLine(vector2.ToString());
                                                Console.WriteLine("Суммарный вектор:");
                                                Console.WriteLine(Vectors.Sum(vector1, vector2).ToString());
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Невозможно сложить вектора. Разные длины");
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "2":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Класс со статическими методами.");
                                                Console.WriteLine("Введите количество координат первого вектора:");
                                                int num1 = Int32.Parse(Console.ReadLine());
                                                IVectorable vector1 = new ArrayVector(num1);
                                                for (int i = 0; i < num1; i++)
                                                {
                                                    Console.WriteLine("Введите {0} координату:", i + 1);
                                                    vector1[i] = Double.Parse(Console.ReadLine());
                                                }
                                                Console.WriteLine("Введите количество координат второго вектора:");
                                                int num2 = Int32.Parse(Console.ReadLine());
                                                IVectorable vector2 = new ArrayVector(num2);
                                                for (int i = 0; i < num2; i++)
                                                {
                                                    Console.WriteLine("Введите {0} координату:", i + 1);
                                                    vector2[i] = Double.Parse(Console.ReadLine());
                                                }
                                                Console.Clear();
                                                Console.WriteLine("Класс со статическими методами.");
                                                Console.WriteLine("Ваш первый вектор: ");
                                                Console.WriteLine(vector1.ToString());
                                                Console.WriteLine("Ваш второй вектор: ");
                                                Console.WriteLine(vector2.ToString());
                                                Console.WriteLine("Скалярное произведение векторов: {0}",Vectors.Scalar(vector1,vector2));
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Невозможно посчитать скалярное произведение. Разные длины.");
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.WriteLine("Класс со статическими методами.");
                                            Console.WriteLine("Введите количество координат вектора:");
                                            int num = Int32.Parse(Console.ReadLine());
                                            ArrayVector vector = new ArrayVector(num);
                                            for (int i = 0; i < num; i++)
                                            {
                                                Console.WriteLine("Введите {0} координату:", i + 1);
                                                vector[i] = Double.Parse(Console.ReadLine());
                                            }
                                            Console.Clear();
                                            Console.WriteLine("Класс со статическими методами.");
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Длина вектора: {0}", Vectors.Norm(vector));
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "0":
                                        {
                                            key1 = false;
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Такого пункта меню нет.Повторите ввод.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "0":
                        {
                            key = false;
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого пункта меню нет.Повторите ввод.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
