using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Vectors
    {
        public static IVectorable Sum(IVectorable v1, IVectorable v2)
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
        public static double Scalar(IVectorable v1, IVectorable v2)
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
        public static double Norm(IVectorable v1)
        {
            double sum = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                sum += Math.Pow(v1[i], 2);
            }
            return Math.Sqrt(sum);
        }
        public static void InputVector(IVectorable v, Stream input)
        {
            byte[] len = new byte[1];
            len[0] = (byte)(v.Length);
            input.Write(len, 0, len.Length);
            for (int i = 0; i < v.Length; i++)
            {
                byte[] value = BitConverter.GetBytes(v[i]);
                input.Write(value,0,value.Length);
            }
            Console.WriteLine();
        }
        public static IVectorable OutputVector(Stream output)
        {
            int len = output.ReadByte();
            IVectorable vector = new LinkedListVector(len);
            for (int i = 0; i < len; i++)
            {
                byte[] value = new byte[8];
                output.Read(value,0,value.Length);
                vector[i] = BitConverter.ToDouble(value, 0);
            }
            return vector;
        }
        public static void WriteVector(IVectorable v, TextWriter output)
        {
            output.WriteLine(v.ToString());
        }
        public static IVectorable ReadVector(TextReader input)
        {
            string[] coordinates = input.ReadLine().Split(' ');
            IVectorable vector = new ArrayVector(Int32.Parse(coordinates[0]));
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Double.Parse(coordinates[i + 1]);
            }
            return vector;
        }
    }
}
