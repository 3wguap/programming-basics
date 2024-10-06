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
            Console.WriteLine("Лабораторная работа №5.Основы языка С#: Стандартные интерфейсы.");
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
                Console.WriteLine("4.Реализация интерфейсов.");
                Console.WriteLine("0.Выход");
                switcher = Console.ReadLine();
                Console.Clear();
                switch (switcher)
                {
                    case "1":
                        {
                            Console.WriteLine("Класс вектор ArrayVector.");
                            Console.WriteLine("Введите количество координат вектора:");
                            int n = Int32.Parse(Console.ReadLine());
                            ArrayVector vector = new ArrayVector(n);
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Введите {0} координату:", i + 1);
                                vector[i] = Double.Parse(Console.ReadLine());
                            }
                            Console.Clear();
                            Console.WriteLine("Класс вектор ArrayVector.");
                            Console.WriteLine("Ваш вектор:");
                            Console.WriteLine(vector.ToString());
                            bool key1 = true;
                            while (key1)
                            {
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
                                            Console.WriteLine("Ваш вектор:");
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
                                            Console.WriteLine("Ваш вектор:");
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
                                            Console.WriteLine("Ваш вектор:");
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Длина вектора: {0}", vector.GetNorm());
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine("Класс вектор ArrayVector.");
                                            Console.WriteLine("Ваш вектор:");
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Количество координат вектора: {0}", vector.Length);
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
                            Console.WriteLine("Класс список LinkedList.");
                            Console.WriteLine("Введите количество координат вектора:");
                            int num = Int32.Parse(Console.ReadLine());
                            LinkedListVector vector = new LinkedListVector(num);
                            for (int i = 0; i < vector.Length; i++)
                            {
                                Console.WriteLine("Введите значение {0} координаты:", i + 1);
                                vector[i] = Double.Parse(Console.ReadLine());
                            }
                            Console.Clear();
                            bool key1 = true;
                            while (key1)
                            {
                                Console.WriteLine("Класс список LinkedList.");
                                Console.WriteLine("Ваш вектор:");
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
                                                Console.WriteLine("Ваш вектор:");
                                                Console.WriteLine(vector.ToString());
                                                Console.WriteLine("Какую координату хотите узнать?");
                                                int n = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine("{0} координата: {1}", n, vector[n - 1]);
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
                                                Console.WriteLine("Ваш вектор:");
                                                Console.WriteLine(vector.ToString());
                                                Console.WriteLine("Какую координату хотите поменять?");
                                                int n = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine("Введите новое значение координаты:");
                                                vector[n - 1] = Double.Parse(Console.ReadLine());
                                                Console.WriteLine("Ваш вектор:");
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
                                            Console.WriteLine("Ваш вектор:");
                                            Console.WriteLine(vector.ToString());
                                            Console.WriteLine("Длина вектора: {0}", vector.GetNorm());
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine("Ваш вектор:");
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
                                                IVectorable vector2 = new ArrayVector(num2);
                                                for (int i = 0; i < num2; i++)
                                                {
                                                    Console.WriteLine("Введите {0} координату:", i + 1);
                                                    vector2[i] = Double.Parse(Console.ReadLine());
                                                }
                                                Console.Clear();
                                                Console.WriteLine("Ваш первый вектор: ");
                                                Console.WriteLine(vector1.ToString());
                                                Console.WriteLine("Ваш второй вектор: ");
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
                                            Console.WriteLine("Ваш вектор:");
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
                    case "4":
                        {
                            Interfaces();
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
        static internal void Interfaces()
        {
            Console.WriteLine("Реализация интерфейсов:");
            Console.WriteLine("Введите количество векторов в массиве:");
            int num = Int32.Parse(Console.ReadLine());
            IVectorable[] ivect = new IVectorable[num];
            for (int i = 0; i < ivect.Length; i++)
            {
                bool key = true;
                while (key)
                {
                    try
                    {
                        Console.WriteLine("Тип {0}-ого элемента: 1 - ArrayVector; 2 - LinkedListVector.", i + 1);
                        string type = Console.ReadLine();
                        if (type == "1")
                        {
                            Console.WriteLine("Введите длину вектора:");
                            int num1 = Int32.Parse(Console.ReadLine());
                            ivect[i] = new ArrayVector(num1);
                            for (int j = 0; j < ivect[i].Length; j++)
                            {
                                Console.WriteLine("Введите {0} координату:", j + 1);
                                ivect[i][j] = Double.Parse(Console.ReadLine());
                            }
                            key = false;
                        }
                        else if (type == "2")
                        {
                            Console.WriteLine("Введите длину вектора:");
                            int num1 = Int32.Parse(Console.ReadLine());
                            ivect[i] = new LinkedListVector(num1);
                            for (int j = 0; j < ivect[i].Length; j++)
                            {
                                Console.WriteLine("Введите {0} координату:", j + 1);
                                ivect[i][j] = Double.Parse(Console.ReadLine());
                            }
                            key = false;
                        }
                        else { throw new Exception("Некорректный ввод."); }
                    }
                    catch (Exception e) { Console.Write(e.Message); Console.WriteLine("Повторите ввод"); }
                }
            }
            Console.Clear();
            Console.WriteLine("Полученный массив:");
            Console.WriteLine("Количество координат | Координаты вектора ");
            for (int i = 0; i < ivect.Length; i++)
            {
                Console.WriteLine(ivect[i].ToString());
            }
            IVectorable max= ivect[1], min = ivect[1];
            for (int i = 0; i < ivect.Length-1; i++)
            {
                if (ivect[i].CompareTo(ivect[i + 1]) >= 0)
                {
                    max = ivect[i];
                    min = ivect[i + 1];
                }
                else
                {
                    max = ivect[i + 1];
                    min = ivect[i];
                }
            }
            int kmax = max.Length;
            int kmin = min.Length;
            Console.WriteLine("Векторы с наибольшим количеством координат и их тип:");
            for (int i = 0; i < ivect.Length; i++)
            {
                if (ivect[i].Length == kmax)
                {
                    Console.Write("{0}\nЕго тип: {1} \n", ivect[i].ToString(), ivect[i].GetType());
                }
                
            }
            Console.WriteLine("Векторы с наименьшим количеством координат и их тип:");
            for (int i = 0; i < ivect.Length; i++)
            {
                if (ivect[i].Length == kmin)
                {
                    Console.Write("{0}\nЕго тип: {1} \n", ivect[i].ToString(), ivect[i].GetType());
                }
            }
            ComparerTest a = new ComparerTest();
            for (int i = 0; i < ivect.Length; i++)
            {
                for (int j = i; j < ivect.Length;j++ )
                {
                    if(a.Compare(ivect[i],ivect[j])>=0)
                    {
                        IVectorable temp = ivect[i];
                        ivect[i] = ivect[j];
                        ivect[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный по возрастанию длины массив:");
            Console.WriteLine("Количество координат | Координаты вектора | Длина вектора");
            for (int i = 0; i < ivect.Length; i++)
            {
                Console.WriteLine(ivect[i].ToString()+ "| {0:.##}",ivect[i].GetNorm());
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Проверка клонирования:");
            Console.WriteLine("Полученный массив:");
            Console.WriteLine("Количество координат | Координаты вектора ");
            for (int i = 0; i < ivect.Length; i++)
            {
                Console.WriteLine(ivect[i].ToString());
            }
            bool key3 = true;
            while (key3)
            {
                Console.WriteLine("Выберите вектор для клонирования:");
                int choice = Int32.Parse(Console.ReadLine())-1;
                if (choice < 0 || choice > ivect.Length-1)
                {
                    Console.WriteLine("Такого вектора нет.Попробуйте снова.");
                }
                else
                {
                    IVectorable clone = (IVectorable)ivect[choice].Clone();
                    Console.Clear();
                    Console.WriteLine("Исходный вектор:");
                    Console.WriteLine("Количество координат | Координаты вектора ");
                    Console.WriteLine(ivect[choice].ToString());
                    Console.WriteLine("Хэш-код: {0}", ivect[choice].GetHashCode());
                    Console.WriteLine("Клонированный вектор:");
                    Console.WriteLine("Количество координат | Координаты вектора ");
                    Console.WriteLine(clone.ToString());
                    Console.WriteLine("Хэш-код: {0}", clone.GetHashCode());
                    try
                    {
                        if (ivect[choice].Equals((IVectorable)clone) == true)
                        {
                            Console.WriteLine("Сравнение Equals: Вектора равны");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("Изменим клон, поменяв знак у каждой координаты");
                    for (int i = 0; i < clone.Length; i++)
                    {
                        clone[i] = -clone[i];
                    }
                    Console.WriteLine("Исходный вектор:");
                    Console.WriteLine("Количество координат | Координаты вектора ");
                    Console.WriteLine(ivect[choice].ToString());
                    Console.WriteLine("Хэш-код: {0}", ivect[choice].GetHashCode());
                    Console.WriteLine("Клонированный вектор:");
                    Console.WriteLine("Количество координат | Координаты вектора ");
                    Console.WriteLine(clone.ToString());
                    Console.WriteLine("Хэш-код: {0}", clone.GetHashCode());
                    try
                    {
                        if (ivect[choice].Equals((IVectorable)clone) == true)
                        {
                            Console.WriteLine("Сравнение Equals: Вектора равны");
                        }
                        else
                        {
                            Console.WriteLine("Вектора не равны по сравнению Equals");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    key3 = false;
                }
            }
        }
    }
}
