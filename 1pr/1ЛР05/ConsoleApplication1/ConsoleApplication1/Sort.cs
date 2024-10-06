using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Sort
    {
        public double[] arr;
        public Sort(int i)
        {
            arr = new double[i];
        }
        public Sort()
        {
            Console.WriteLine("Введите длину массива");
            arr = new double[Int32.Parse(Console.ReadLine())];
        }
        public void Input()
        {
            Console.WriteLine("Введите массив:");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("Введите элемент a[{0}]", j+1);
                arr[j] = Double.Parse(Console.ReadLine());
            }
        }
        public void Output()
        {
            Console.WriteLine("Ваш массив:");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("{0}\t", arr[j]);
            }
            Console.WriteLine();
        }
        public void Bubble()
        {
            for (int j = 0; j < arr.Length; j++)
            { 
                for (int k = 0;k<arr.Length-j-1;k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        double v = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k+1] = v;
                    }
                }
            }
        
        }
        public void Gnome()
        {
            int i = 1;
            int j = 2;
            while (i < arr.Length)
            {
                if (arr[i-1] < arr[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    double v = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = v;
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                
                }
            
            }
        
        }
        public void Shaker()
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        double v = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = v;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        double v = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = v;
                    }
                }
                left++;
            }
        }
    }
}
