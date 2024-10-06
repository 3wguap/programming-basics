using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Fraction_stat
    {
        static public Fraction SumSt(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Denominator + frac1.Denominator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }
        static public Fraction DifSt(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Denominator - frac1.Denominator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }
        static public Fraction MultSt(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }
        static public Fraction DivSt(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Denominator, frac1.Denominator * frac2.Numerator);
        }

    }
}
/* Я умру хлебороб,- ел хурму я*/