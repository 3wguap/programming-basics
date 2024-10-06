using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ArrayVector
    {
        private double[] coords;
        public ArrayVector(int len)
        {
            coords = new double[len];
        }
        public ArrayVector()
        {
            coords = new double[5] { 1, 2, 3, 4, 5 };
        }

        public double this[int ind]
        {
            get
            {
                if (ind > Length || ind < 0)
                {
                    throw new Exception("Ошибочный индекс.");
                }
                return coords[ind];
            }
            set
            {
                if (ind > Length || ind < 0)
                {
                    throw new Exception("Элемента с таким индексом нет.");
                }
                coords[ind] = value;
            }
        }
        public int Length
        {
            get { return coords.Length; }
        }
        public void Print()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write("{0} ", coords[i]);
            }
            Console.WriteLine();
        }
        public double GetNorm()
        {
            double sum = 0;
            for (int i = 0; i < Length; i++)
            {
                sum += Math.Pow(coords[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
