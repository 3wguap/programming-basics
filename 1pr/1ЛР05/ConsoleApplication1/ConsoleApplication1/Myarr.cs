using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Myarr
    {
        public double[,] twodim_arr;
        public Myarr(int i, int j)
        {
            twodim_arr = new double[i,j];
        }
        public Myarr()
        {
            twodim_arr = new double [1,1];
        }
        public void Filler()
        {
            Random rand  =  new Random();
            for (int i = 0; i < twodim_arr.GetLength(0); i++)
            {
                for (int j = 0; j < twodim_arr.GetLength(1); j++)
                {
                    twodim_arr[i, j] = rand.Next(-100,100);
                }
            }
        }
        public void Output()
        {
            for (int i = 0; i < twodim_arr.GetLength(0); i++)
            {
                for (int j = 0; j < twodim_arr.GetLength(1); j++)
                {
                    Console.Write(twodim_arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Sortinc()
        {
            for (int k = 0; k < twodim_arr.GetLength(1); k++)
            {
                for (int j = 1; j < twodim_arr.GetLength(1); j++)
                {
                    double sum1 = 0;
                    for (int i = 0; i < twodim_arr.GetLength(0); i++)
                    {
                        sum1 += twodim_arr[i, j];
                    }
                    double sum2 = 0;
                    for (int i = 0; i < twodim_arr.GetLength(0); i++)
                    {
                        sum2 += twodim_arr[i, j - 1];
                    }
                    if (sum1 < sum2)
                    {
                        for (int i = 0; i < twodim_arr.GetLength(0); i++)
                        {
                            double temp = twodim_arr[i, j];
                            twodim_arr[i, j] = twodim_arr[i, j - 1];
                            twodim_arr[i, j - 1] = temp;
                        } 
                    }
                }

            }
        
        }
        public void Sortdec()
        {
            for (int k = 0; k < twodim_arr.GetLength(1); k++)
            {
                for (int j = 1; j < twodim_arr.GetLength(1); j++)
                {
                    double sum1 = 0;
                    for (int i = 0; i < twodim_arr.GetLength(0); i++)
                    {
                        sum1 += twodim_arr[i, j];
                    }
                    double sum2 = 0;
                    for (int i = 0; i < twodim_arr.GetLength(0); i++)
                    {
                        sum2 += twodim_arr[i, j - 1];
                    }
                    if (sum1 > sum2)
                    {
                        for (int i = 0; i < twodim_arr.GetLength(0); i++)
                        {
                            double temp = twodim_arr[i, j];
                            twodim_arr[i, j] = twodim_arr[i, j - 1];
                            twodim_arr[i, j - 1] = temp;
                        }
                    }
                }

            }
        
        }
    }
}
