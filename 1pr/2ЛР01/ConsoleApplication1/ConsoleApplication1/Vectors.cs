using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Vectors
    {
        static public ArrayVector Sum(ArrayVector v1, ArrayVector v2)
        {
            try
            {
                if (v1.coords.Length != v2.coords.Length)
                {
                    throw new Exception("Разные размерности векторов.");
                }
                ArrayVector v3 = new ArrayVector(v1.coords.Length);
                for (int i = 0; i < v3.coords.Length; i++)
                {
                    v3.coords[i] = v1.coords[i] + v2.coords[i];
                }
                return v3;
            }
            catch
            {
                Console.WriteLine("Ошибка. Разные размерности векторов.");
                Console.WriteLine("Возвращен первый вектор.");
            }
            return v1;
        }
        static public double Scalar(ArrayVector v1, ArrayVector v2)
        {
            try
            {
                double sum = 0;
                if (v1.coords.Length != v2.coords.Length)
                {
                    throw new Exception("Разные размерности векторов.");
                }
                for (int i = 0; i < v1.coords.Length; i++)
                {
                    sum += v1.coords[i] * v2.coords[i];
                }
                return sum;
            }
            catch
            {
                Console.WriteLine("Ошибка. Разные размерности векторов.");
                Console.WriteLine("Возвращено значение 0.");
            }
            return 0;
        }
        static public ArrayVector Mult(ArrayVector v1, int n)
        {
            ArrayVector v3 = new ArrayVector(v1.coords.Length);
            for (int i = 0; i < v3.coords.Length; i++)
            {
                v3.coords[i] = v1.coords[i] *n;
            }
            return v3;
        }
        static public double Norm(ArrayVector v1)
        {
            double sum = 0;
            for (int i = 0; i < v1.coords.Length; i++)
            {
                sum += Math.Pow(v1.coords[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
