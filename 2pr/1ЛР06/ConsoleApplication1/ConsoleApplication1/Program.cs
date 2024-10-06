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
            Console.WriteLine("Лабораторная работа №6.Основы языка С#: Классы");
            Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
            Console.WriteLine("В рамках курса \"Основы программирования\"");
            bool verifier0 = true;
            while (verifier0)
            {
                Console.WriteLine("Задания на дроби:");
                Console.WriteLine("1.Методы");
                Console.WriteLine("2.Статические методы");
                Console.WriteLine("3.Переопределение операций");
                Console.WriteLine("0.Выход");
                string choice0 = Console.ReadLine();
                switch (choice0)
                {
                    case "1":
                        {
                            bool verifier1 = true;
                            while (verifier1)
                            {
                                Console.WriteLine("Действия:");
                                Console.WriteLine("1.Сложение");
                                Console.WriteLine("2.Вычитание");
                                Console.WriteLine("3.Умножение");
                                Console.WriteLine("4.Деление");
                                Console.WriteLine("5.Сократить");
                                Console.WriteLine("0.Выход");
                                string n = Console.ReadLine();
                                if (n == "1")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1,den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = x.Sum(y);
                                    z = z.Cutter();
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Output();
                                }
                                else if (n == "2")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = x.Dif(y);
                                    z = z.Cutter();
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Output();
                                }
                                else if (n == "3")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = x.Multiplication(y);
                                    z = z.Cutter();
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Output();
                                }
                                else if (n == "4")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = x.Division(y);
                                    z = z.Cutter();
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Output();
                                }
                                else if (n == "5")
                                {
                                    Console.WriteLine("Введите числитель дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Ваша дробь:");
                                    x.Output();
                                    x = x.Cutter();
                                    Console.WriteLine("Итоговая дробь:");
                                    x.Output();
                                }
                                else if (n == "0")
                                {
                                    verifier1 = false;
                                }
                            }
                            break;
                        }
                    case "2":
                        {
                            bool verifier2 = true;
                            while (verifier2)
                            {
                                Console.WriteLine("Действия:");
                                Console.WriteLine("1.Сложение");
                                Console.WriteLine("2.Вычитание");
                                Console.WriteLine("3.Умножение");
                                Console.WriteLine("4.Деление");
                                Console.WriteLine("0.Выход");
                                string n = Console.ReadLine();
                                if (n == "1")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = Fraction_stat.SumSt(x,y);
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "2")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = Fraction_stat.DifSt(x, y);
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "3")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = Fraction_stat.MultSt(x, y);
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "4")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    z = Fraction_stat.DivSt(x, y);
                                    Console.WriteLine("Итоговая дробь:");
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "0")
                                {
                                    verifier2 = false;
                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            bool verifier3 = true;
                            while (verifier3)
                            {
                                Console.WriteLine("Действия:");
                                Console.WriteLine("1.Сложение");
                                Console.WriteLine("2.Вычитание");
                                Console.WriteLine("3.Умножение");
                                Console.WriteLine("4.Деление");
                                Console.WriteLine("0.Выход");
                                string n = Console.ReadLine();
                                if (n == "1")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    Console.WriteLine("Итоговая дробь:");
                                    z = x + y;
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "2")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    Console.WriteLine("Итоговая дробь:");
                                    z = x - y;
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "3")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    Console.WriteLine("Итоговая дробь:");
                                    z = x * y;
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "4")
                                {
                                    Console.WriteLine("Введите числитель первой дроби");
                                    int num1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель первой дроби");
                                    int den1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите числитель второй дроби");
                                    int num2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите знаменатель второй дроби");
                                    int den2 = Int32.Parse(Console.ReadLine());
                                    Fraction x = new Fraction(num1, den1);
                                    Console.WriteLine("Первая  дробь:");
                                    x.Output();
                                    Fraction y = new Fraction(num2, den2);
                                    Console.WriteLine("Вторая дробь:");
                                    y.Output();
                                    Fraction z = new Fraction();
                                    Console.WriteLine("Итоговая дробь:");
                                    z = x / y;
                                    z.Cutter();
                                    z.Output();
                                }
                                else if (n == "0")
                                {
                                    verifier3 = false;
                                }

                            }
                            break;
                        }
                    case "0":
                        {
                            verifier0 = false;
                            break;
                        }
                }
            }
        }
    }
}
