using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1
{
     class Rational
    {
        public class NullDivision : Exception { };

        private int n;
        private int d;

        public Rational(int i, int j)
        {
            if (j == 0)
            {
                throw new Exception();
            }
            n = i;
            d = j;
        }

        public static Rational Add (Rational a, Rational b)
        {
            return new Rational(a.n * b.d + a.d * b.n, a.d * b.d);
        }
        public static Rational Substract(Rational a, Rational b)
        {
            return new Rational(a.n * b.d - a.d * b.n, a.d * b.d);
        }
        public static Rational Multiply(Rational a, Rational b)
        {
            return new Rational(a.n * b.n, a.d * b.d);
        }
        public static Rational Divide(Rational a, Rational b)
        {
            if (b.n == 0)
            {
                throw new NullDivision();
            }
            return new Rational(a.n * b.d, a.d * b.n);
        }

        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(a.n * b.d + a.d * b.n, a.d * b.d);
        }
        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(a.n * b.d - a.d * b.n, a.d * b.d);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.n * b.n, a.d * b.d);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            if (b.n == 0)
            {
                throw new Exception();
            }
            return new Rational(a.n * b.d, a.d * b.n);
        }

        public override string ToString()
        {
            return String.Format($"{n:#}/{d:#}");
        }
    }
}
