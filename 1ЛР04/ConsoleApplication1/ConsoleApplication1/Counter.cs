using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Counter
    {
        public int minimum;
        public int maximum;
        public int current;
        public Counter(int min, int max, int cur)
        {
            if (max > min)
            {
                if (cur < min)
                    current = max;
                else if (cur > max)
                    current = min;
                else
                    current = cur;
                minimum = min;
                maximum = max;
            }
            else
            {
                if (cur < max)
                    current = min;
                else if (cur > min)
                    current = max;
                else
                    current = cur;
                minimum = max;
                maximum = min;
            }
        }
        public void Increaser()
        {
            if (current  == maximum)
                current = minimum;
            else
                current = (current + 1);
        }
        public void Decreaser()
        {
            if (current == minimum)
                current = maximum;
            else
                current = current - 1;
        }

        public void Currentness()
        {
            Console.WriteLine("Значение счетчика равно {0}\n", current);
        }
    }
}
