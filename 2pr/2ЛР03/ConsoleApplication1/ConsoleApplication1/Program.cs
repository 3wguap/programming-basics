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
            Console.WriteLine("Лабораторная работа №3.Основы языка С#: Перечисления.");
            Console.WriteLine("Выполнил студент группы 6104-020302D Свиридов Кирилл");
            Console.WriteLine("В рамках курса \"Основы программирования\"");
            bool key = true;
            Employee[] emp = Employee.Enter();
            Console.Clear();
            while (key)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1.Полный список.");
                Console.WriteLine("2.Поиск по должности.");
                Console.WriteLine("3.Менеджеры с зарплатой выше чем средняя у клерков.");
                Console.WriteLine("4.Сотрудники принятые позже босса.");
                Console.WriteLine("0.Выход.");
                string switcher = Console.ReadLine();
                Console.Clear();
                switch (switcher)
                {
                    case "1":
                        {
                            Console.WriteLine("Полный список сотрудников.");
                            Console.WriteLine("Данные о сотрудниках:");
                            Console.WriteLine("Имя - Вакансия - Зарплата - Дата приема на работу.");
                            for (int i = 0; i < emp.Length; i++)
                            {
                                Console.WriteLine(emp[i].ToString());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Поиск по должности.");
                            Console.WriteLine("Должности: Boss - CEO - Manager - Clerk - Salesman");
                            Console.Write("Введите нужную вам должность: ");
                            string Vacancy = Console.ReadLine();
                            int k=0;
                            try
                            {
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i].Vacancy.ToString() == Vacancy)
                                    {
                                        Console.WriteLine(emp[i].ToString());
                                        k += 1;
                                    }
                                }
                                if (k == 0)
                                {
                                    throw new Exception("No employees with such Vacancy.");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Менеджеры с зарплатой выше чем средняя у клерков.");
                            int average = 0, count = 0;
                            for (int i = 0; i < emp.Length; i++)
                            {
                                if (emp[i].Vacancy.ToString() == "Clerk")
                                {
                                    average += emp[i].Salary;
                                    count++;
                                }
                            }
                            try
                            {
                                if (count==0)
                                {
                                    throw new Exception("Clerks not found. Printed all managers.");
                                }
                                average /= count;
                                count = 0;
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i].Vacancy.ToString() == "Manager" && emp[i].Salary > average)
                                    {
                                        count++;
                                    }
                                }
                                if (count == 0)
                                {
                                    throw new Exception("Managers not found.");
                                }
                                Employee[] emp2 = new Employee[count];
                                int k = 0;
                                for (int i = 0; i < emp.Length; i++)
                                {

                                    if (emp[i].Vacancy.ToString() == "Manager" && emp[i].Salary > average)
                                    {
                                        emp2[k] = emp[i];
                                        k++;
                                    }

                                }
                                for (int i = 0; i < emp2.Length; i++)
                                {
                                    for (int j = i + 1; j < emp2.Length; j++)
                                    {
                                        Employee temp;
                                        if (emp2[i].Name.CompareTo(emp2[j].Name) > 0)
                                        {
                                            temp = emp2[i];
                                            emp2[i] = emp2[j];
                                            emp2[j] = temp;
                                        }
                                    }
                                }
                                for (int i = 0; i < emp2.Length; i++)
                                {
                                    Console.WriteLine(emp2[i].ToString());
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i].Vacancy.ToString() == "Manager")
                                    {
                                        Console.WriteLine(emp[i].ToString());
                                    }
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Сотрудники принятые позже босса.");
                            int day, month, year;
                            day = month = year = 0;
                            for (int i = 0; i < emp.Length;i++ )
                            {
                                if (emp[i].Vacancy.ToString() == "Boss")
                                {
                                    day = emp[i].Day;
                                    month = emp[i].Month;
                                    year = emp[i].Year;
                                }
                            }
                            try
                            {
                                if (day == 0)
                                {
                                    throw new Exception("Boss not found.");
                                }
                                int count = 0;
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i].Vacancy.ToString() != "Boss")
                                    {
                                        if (emp[i].Year > year)
                                        {
                                            count++;
                                        }
                                        else if (emp[i].Year == year)
                                        {
                                            if (emp[i].Month > month)
                                            {
                                                count++;
                                            }
                                            else if (emp[i].Month == month)
                                            {
                                                if (emp[i].Day > day)
                                                {
                                                    count++;
                                                }
                                            }
                                        }
                                    }
                                }
                                Employee[] emp2 = new Employee[count];
                                int k = 0;
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i].Vacancy.ToString() != "Boss")
                                    {
                                        if (emp[i].Year > year)
                                        {
                                            emp2[k] = emp[i];
                                            k++;
                                        }
                                        else if (emp[i].Year == year)
                                        {
                                            if (emp[i].Month > month)
                                            {
                                                emp2[k] = emp[i];
                                                k++;
                                            }
                                            else if (emp[i].Month == month)
                                            {
                                                if (emp[i].Day > day)
                                                {
                                                    emp2[k] = emp[i];
                                                    k++;
                                                }
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < emp2.Length; i++)
                                {
                                    for (int j = i + 1; j < emp2.Length; j++)
                                    {
                                        Employee temp;
                                        if (emp2[i].Name.CompareTo(emp2[j].Name) > 0)
                                        {
                                            temp = emp2[i];
                                            emp2[i] = emp2[j];
                                            emp2[j] = temp;
                                        }
                                    }
                                }
                                for (int i = 0; i < emp2.Length; i++)
                                {
                                    Console.WriteLine(emp2[i].ToString());
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.WriteLine("Выведены все сотрудники:");
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    Console.WriteLine(emp[i].ToString());
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "0":
                        {
                            key = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого пункта меню нет. Повторите ввод.");
                            break;
                        }
                }
            }
        }
        
    }
}
