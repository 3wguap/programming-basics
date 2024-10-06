﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Vectors
    {
        static public IVectorable Sum(IVectorable v1, IVectorable v2)
        {
                if (v1.Length != v2.Length)
                {
                    throw new Exception("Разные размерности векторов.");
                }
                IVectorable v3 = new ArrayVector(v1.Length);
                for (int i = 0; i < v3.Length; i++)
                {
                    v3[i] = v1[i] + v2[i];
                }
                return v3;
        }
        static public double Scalar(IVectorable v1, IVectorable v2)
        {

                double sum = 0;
                if (v1.Length != v2.Length)
                {
                    throw new Exception("Разные размерности векторов.");
                }
                for (int i = 0; i < v1.Length; i++)
                {
                    sum += v1[i] * v2[i];
                }
                return sum;
        }
        static public double Norm(IVectorable v1)
        {
            double sum = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                sum += Math.Pow(v1[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
