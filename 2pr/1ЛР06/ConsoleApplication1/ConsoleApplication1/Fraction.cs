using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set 
            {
                if (value == 0)
                {
                    Console.WriteLine("Полученный знаменатель равен 0. Присвоено значение 1.");
                    denominator = 1;
                }
                else { denominator = value; }
            }
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;

        }
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction Sum(Fraction frac1)
        {
            Fraction frac = new Fraction();
            if (Denominator == frac1.Denominator)
            {
                frac.Numerator = Numerator + frac1.Numerator;
                frac.Denominator = Denominator;
            }
            else
            {
                frac.Numerator = Numerator * frac1.Denominator + frac1.Numerator * Denominator;
                frac.Denominator = Denominator * frac1.Denominator;
            }
            return frac;
        }
        public Fraction Dif(Fraction frac1)
        {
            Fraction frac = new Fraction();
            if (Denominator == frac1.Denominator)
            {
                frac.Numerator = Numerator - frac1.Numerator;
                frac.Denominator = Denominator;
            }
            else
            {
                frac.Numerator = Numerator * frac1.Denominator - frac1.Numerator * Denominator;
                frac.Denominator = Denominator * frac1.Denominator;
            }
            return frac;
        }
        public Fraction Multiplication(Fraction frac1)
        {
            Fraction frac = new Fraction();
            frac.Numerator = Numerator * frac1.Numerator;
            frac.Denominator = Denominator * frac1.Denominator;
            return frac;
        }
        public Fraction Division(Fraction frac1)
        {
            Fraction frac = new Fraction();
            frac.Numerator = Numerator * frac1.Denominator;
            frac.Denominator = Denominator * frac1.Numerator;
            return frac;
        }
        public Fraction Cutter()
        {
            int nod = Nod(Numerator,Denominator);
            if (nod != 0)
            {
                Numerator /= nod;
                Denominator /= nod;
            }
            Fraction frac = new Fraction(Numerator,Denominator);
            return frac;
        }
        public int Nod(int n, int d)
        {
            int temp;
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            else return 0;
        }
        public void Output()
        {
            Console.WriteLine("{0} / {1}", Numerator, Denominator);
        }
        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Denominator + frac1.Denominator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }
        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Denominator - frac1.Denominator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }
        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }
        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Numerator * frac2.Denominator, frac1.Denominator * frac2.Numerator);
        }

    }
}
