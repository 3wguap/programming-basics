using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LinkedListVector: IVectorable
    {
        private Node start;

        public class Node
        {
            public double nodevalue;
            public Node link  = null;
        }
        public LinkedListVector(int len)
        {
            start = new Node();
            Node cur = start;
            for (int i = 0; i < len - 1; i++)
            {
                cur.link = new Node();
                cur = cur.link;
            }
        }
        public LinkedListVector()
        {
            start = new Node();
            Node cur = start;
            for (int i = 0; i < 4; i++)
            {
                cur.link = new Node();
                cur = cur.link;
            }
        }
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                {
                    Node cur = start;
                    for (int i = 0; i < index; i++)
                    {
                        cur = cur.link;
                    }
                    return cur.nodevalue;
                }
                else
                {
                    throw new Exception("Введен неверный индекс.");
                }
            }
            set
            {
                if (index >= 0 && index < Length)
                {
                    Node cur = start;
                    for (int i = 0; i < index; i++)
                    {
                        cur = cur.link;
                    }
                    cur.nodevalue = value;
                }
                else
                {
                    throw new Exception("Введен неверный индекс.");
                }
            }
        }
        public void Print()
        {
            Node cur = start;
            Console.WriteLine("Ваш вектор:");
            for (int i = 0; i < Length; i++)
            {
                Console.Write("{0} ",cur.nodevalue);
                cur = cur.link;
            }
            Console.WriteLine();
        }
        public double GetNorm()
        {
            double norm = 0;
            Node cur = start;
            for (int i = 0; i < Length;i++ )
            {
                norm += Math.Pow(cur.nodevalue, 2);
                cur = cur.link;
            }
            return Math.Sqrt(norm);
        }
        public int Length
        {
            get
            {
                int length = 0;
                Node cur = start;
                while (cur != null)
                {
                    cur = cur.link;
                    length++;
                }
                return length;
            }
        }
        public override string ToString()
        {
            Node cur = start;
            Console.WriteLine("Ваш вектор:");
            string over = Length.ToString();
            for (int i = 0; i < Length;i++)
            {
                over += " " +cur.nodevalue.ToString();
                cur = cur.link;
            }
            return over;
        }
        public void AddTop(double element)
        {
            Node temp = new Node();
            temp.nodevalue = element;
            temp.link = start;
            start = temp;
        }
        public void AddEnd(double element)
        {
            Node cur = start;
            while (cur.link != null)
            {
                cur = cur.link;
            }
            cur.link = new Node();
            cur.link.nodevalue = element;
        }
        public void DeleteTop()
        {
            start = start.link;
        }
        public void DeleteEnd()
        {
            Node cur = start;
            for (int i = 0; i < Length - 2; i++)
            {
                cur = cur.link;
            }
            cur.link = null;
        }
        public void AddInd(int ind, double element)
        {
            if (ind < 0 || ind >= Length)
            {
                throw new Exception("Индекс выходит за границы");
            }
            else
            {
                Node cur = start;
                for (int i = 0; i < ind - 1; i++)
                {
                    cur = cur.link;
                }
                Node temp = new Node();
                temp.nodevalue = element;
                temp.link = cur.link;
                cur.link = temp;
            }
        }
        public void DeleteInd(int ind)
        {
            if (ind < 0 || ind >= Length)
            {
                throw new Exception("Индекс выходит за границы");
            }
            else
            {
                Node cur = start;
                for (int i = 0; i < ind - 1; i++)
                {
                    cur = cur.link;
                }
                cur.link = cur.link.link;
            }
        }
    }
}
