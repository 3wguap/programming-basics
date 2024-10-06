using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Stepped
    {
        public double[][] step_mas;
        public Stepped(int n, int[]m)
        {
            step_mas = new double[n][];
            for (int k = 0; k < n; k++)
            {

                step_mas[k] = new double[m[k]];
            }
        }
        public void Input()
        {
            Console.WriteLine("Ввод массива:");
            for (int i = 0; i < step_mas.Length; i++)
            {
                for (int j = 0; j < step_mas[i].Length; j++)
                {
                    Console.WriteLine("Введите элемент [{0}][{1}]:",i+1,j+1);
                    step_mas[i][j] = Double.Parse(Console.ReadLine());
                }
            }
        }
        public void Output()
        {
            Console.WriteLine("Итоговый массив");
            for (int i = 0; i < step_mas.Length; i++)
            {
                for (int j = 0; j < step_mas[i].Length; j++)
                {
                    Console.Write(step_mas[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }
        public void Sort()
        {
            int v = 0;
            for (int i = 0; i < step_mas.Length; i++)
            {
                v += step_mas[i].Length;
            }
            double[] s = new double[v];
            int k = 0;
            for (int i = 0; i < step_mas.Length; i++)
            {
                if (i > 0)
                {
                    k += step_mas[i-1].Length;
                }
                for (int j = 0; j < step_mas[i].Length; j++)
                {
                    s[j + k] = step_mas[i][j];
                }
            }
            double a;
            for (int i = 0; i < v - 1; i++)
            {
                for (int j = 0; j < v - i - 1; j++)
                {
                    if (s[j + 1] < s[j])
                    {
                        a = s[j + 1];
                        s[j + 1] = s[j];
                        s[j] = a;
                    }
                }
            }
            k = 0;
            for (int i = 0; i < step_mas.Length; i++)
            {
                if (i > 0)
                {
                    k += step_mas[i-1].Length;
                }
                for (int j = 0; j < step_mas[i].Length; j++)
                {
                    {
                        step_mas[i][j] = s[j + k];
                    }
                }
            }
        }
    }
}
