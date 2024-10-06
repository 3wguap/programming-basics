using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IVectorable
    {
        double this[int index]
        { get; set; }
        int Length
        { get; }
        double GetNorm();
    }
}
