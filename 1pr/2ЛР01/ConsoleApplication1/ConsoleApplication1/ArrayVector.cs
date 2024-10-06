using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ArrayVector
    {
        public int[] coords;
        public ArrayVector(int len)
        {
            coords = new int[len];
        }
        public ArrayVector()
        {
            coords = new int[5] { 1, 2, 3, 4, 5 };
        }
        public void SetElement(int ind, int value)
        {
            try
            {
                coords[ind] = value;
            }
            catch
            {
                Console.WriteLine("Элемента с таким номером нет.");
            }
        }
        public void GetElement(int ind)
        {
            try
            {
                Console.WriteLine("Координата вектора с номером {0}: {1}", ind + 1, coords[ind]);
            }
            catch 
            {
                Console.WriteLine("Элемента с таким номером нет.");
            }
        }
        public void Print()
        {
            for (int i = 0; i < coords.Length; i++)
            {
                Console.Write("{0} ",coords[i]);
            }
            Console.WriteLine();
        }
        public double GetNorm()
        { 
            double sum = 0;
            for (int i = 0; i < coords.Length; i++)
            {
                sum+= Math.Pow(coords[i], 2);
            }
            return Math.Sqrt(sum);
        }
        public int SumPositives()
        {
            int sum = 0;
            for (int i = 0; i < coords.Length; i++)
            {
                if (coords[i] > 0 && i % 2 != 0)
                {
                    sum += coords[i];
                }
            }
            if (sum != 0)
            {
                return sum;
            }
            else return -1;
        }
        public string SumLess()
        {
            int sum = 0;
            int k = 0; ;
            double average = 0;
            for (int i = 0; i < coords.Length; i++)
            { 
                sum+= Math.Abs(coords[i]);
            }
            average = sum/coords.Length;
            sum = 0;
            for (int i = 0; i < coords.Length; i++)
            {
                if (i % 2 == 0 && coords[i] < average)
                {
                    sum += coords[i];
                    k++;
                }
            }
            if (k != 0)
            {
                return Convert.ToString(sum);
            }
            else
            {
                return "Таких нет";
            }
        }
        public int MultEven()
        {
            int mult = 1;
            for (int i = 0; i < coords.Length; i++)
            {
                if (coords[i] % 2 == 0 && coords[i] > 0)
                {
                    mult *= coords[i];
                }
            }
            return mult;
        }
        public string MultOdd()
        {
            int mult = 1;
            int k = 0;
            for (int i = 0; i < coords.Length; i++)
            {
                if (coords[i] % 2 != 0 && coords[i] % 3 != 0)
                {
                    mult *= coords[i];
                    k++;
                }
            }
            if (k != 0)
            {
                return Convert.ToString(mult);
            }
            else
            {
                return "Таких нет";
            }
        }
        public void SortUp()
        {
            for (int i = 0; i < coords.Length; i++)
            {
                for (int j = i+1; j < coords.Length; j++)
                {
                    if (coords[i] > coords[j])
                    {
                        int v = coords[i];
                        coords[i] = coords[j];
                        coords[j] = v;
                    }
                }
            }
        }
        public void SortDown()
        {
            for (int i = 0; i < coords.Length; i++)
            {
                for (int j = i + 1; j < coords.Length; j++)
                {
                    if (coords[i] < coords[j])
                    {
                        int v = coords[i];
                        coords[i] = coords[j];
                        coords[j] = v;
                    }
                }
            }
        }
    }
}
