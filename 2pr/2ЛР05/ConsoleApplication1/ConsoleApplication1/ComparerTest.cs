using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class ComparerTest: IComparer
    {
        public int a = 0;
        public int Compare(object v1, object v2)
        {
            if (((IVectorable)v1).GetNorm() > ((IVectorable)v2).GetNorm())
            {
                return 1;
            }
            else if (((IVectorable)v1).GetNorm() < ((IVectorable)v2).GetNorm())
            {
                return -1;
            }
            else { return 0; }
        }
    }
}
