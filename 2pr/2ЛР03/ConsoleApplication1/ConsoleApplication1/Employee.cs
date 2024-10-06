using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    struct Employee
        {
            private string name;
            private Vacancies vacancy;
            private int salary;
            private int[] hiredate;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Vacancies Vacancy
            {
                get { return vacancy; }
                set { vacancy = value; }
            }
            public int Salary
            {
                get { return salary; }
                set 
                {
                    if (value < 0)
                    {
                        throw new Exception("Введена некорректная сумма.");
                    }
                    else
                    {
                        salary = value;
                    }
                }
            }
            public int[] Hiredate
            {
                get { return hiredate; }
                set { hiredate = value; }
            }
            public int Day
            {
                get
                { return hiredate[0]; }
                set 
                {
                    if (value > 31 || value < 1)
                    {
                        throw new Exception("Неверный формат дня.");
                    }
                    else
                    {
                        hiredate[0] = value; 
                    }
                }
            }
            public int Month
            {
                get { return hiredate[1]; }
                set 
                {
                    if (value > 12 || value < 1)
                    {
                        throw new Exception("Неверный формат месяца.");
                    }
                    else
                    {
                        hiredate[1] = value;
                    }
                }
            }
            public int Year
            {
                get { return hiredate[2]; }
                set 
                {
                    if (value < 1 || value > 2023)
                    {
                        throw new Exception("Неверный формат года.");
                    }
                    else
                    {
                        hiredate[2] = value;
                    }
                }
            }
            public override string ToString()
            {
                return (Name + " - " + Vacancy + " - " + Salary.ToString() + "$ - " + Day.ToString() + "." + Month.ToString() + "." + Year.ToString());
            }
            static public Employee[] Enter()
            {
                Console.WriteLine("Ввод списка сотрудников:");
                Console.Write("Введите количество сотрудников: ");
                int num = Int32.Parse(Console.ReadLine());
                Employee[] emp1 = new Employee[num];
                for (int i = 0; i < num; i++)
                {
                    emp1[i].Hiredate = new int[3];
                    Console.WriteLine("{0}-й сотрудник:", i + 1);
                    Console.Write("Введите имя: ");
                    emp1[i].Name = Console.ReadLine();
                    bool key1 = true;
                    while (key1)
                    {
                        Console.WriteLine("Введите должность: 1- Boss 2 - CEO 3 - Manager 4 - Clerk 5 - Salesman");
                        string a = Console.ReadLine();
                        switch (a)
                        {
                            case "1": { emp1[i].Vacancy = Vacancies.Boss; key1 = false; break; }
                            case "2": { emp1[i].Vacancy = Vacancies.CEO; key1 = false; break; }
                            case "3": { emp1[i].Vacancy = Vacancies.Manager; key1 = false; break; }
                            case "4": { emp1[i].Vacancy = Vacancies.Clerk; key1 = false; break; }
                            case "5": { emp1[i].Vacancy = Vacancies.Salesman; key1 = false; break; }
                            default: { Console.WriteLine("No such Vacancy.Try again."); break; }
                        }
                    }
                    bool key2 = true;
                    while (key2)
                    {
                        try
                        {
                            Console.Write("Введите заработную плату: ");
                            emp1[i].Salary = Int32.Parse(Console.ReadLine());
                            key2 = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Try again.");
                        }
                    }
                    bool key3 = true;
                    while (key3)
                    {
                        try
                        {
                            Console.Write("Введите день приема сотрудника: ");
                            emp1[i].Day = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите месяц приема сотрудника: ");
                            emp1[i].Month = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите год приема сотрудника: ");
                            emp1[i].Year = Int32.Parse(Console.ReadLine());
                            key3 = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Try again.");
                        }
                    }
                    Console.WriteLine(emp1[i].ToString());
                }
                return emp1;
            }
        }
        enum Vacancies
        {
            Manager,
            Boss,
            CEO,
            Clerk,
            Salesman
        }
        
}
