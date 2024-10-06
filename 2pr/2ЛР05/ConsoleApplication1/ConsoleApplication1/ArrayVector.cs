using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ArrayVector: IVectorable, IComparable, ICloneable
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
            get{ return coords.Length; }
        }
        public void Print()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write("{0} ",coords[i]);
            }
            Console.WriteLine();
        }
        public double GetNorm()
        { 
            double sum = 0;
            for (int i = 0; i < Length; i++)
            {
                sum+= Math.Pow(coords[i], 2);
            }
            return Math.Sqrt(sum);
        }
        public override string ToString()
        {
            string over =Length.ToString()+ " | ";
            for (int i = 0; i < Length; i++)
            {
                over += " " + coords[i].ToString();
            }
            return over;
        }
        public override bool Equals(Object obj)
        {
            if (!(obj is IVectorable) || (Length!= ((IVectorable)obj).Length))
            {
                return false;
            }
            else
            {
                if (GetType() != obj.GetType())
                {
                    throw new Exception("Взяты объекты разных классов ArrayVector и LinkedListVector");
                }
                for (int i = 0; i < Length;i++ )
                {
                    if (coords[i] != ((IVectorable)obj)[i]) { return false; }
                }
                return true;
            }
        }
        public override int GetHashCode()
        {
            int hash = 0;
            for (int i = 0; i < Length; i++)
            {
                hash += (int)coords[i];
            }
            return hash;
        }
        public int CompareTo(Object obj)
        {

            if (!(obj is IVectorable))
            {
                throw new Exception("Cannot be compared.");
            }
            else
            {
 /*               if (GetType() != obj.GetType())
                {
                    throw new Exception("Взяты объекты разных классов ArrayVector и LinkedListVector");
                }*/
                if (Length < ((IVectorable)obj).Length)
                {
                    return -1;
                }
                else if (coords.Length > ((IVectorable)obj).Length)
                {
                    return 1;
                }
                return 0;
            }
        }
        public Object Clone()
        {
            ArrayVector clone = new ArrayVector(Length);
            for (int i = 0; i < Length; i++)
            {
                clone[i] = coords[i];
            }
            return clone;
        }
    }
}
