using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Fraction
    {
        protected long Numerator;
        protected long Denominator;
        public Fraction(long n, long d)
        {
            Numerator = n;
            Denominator = d;
            Fix();
        }
        public Fraction(long n)
        {
            Numerator = n;
            Denominator = 1;
        }
        public Fraction(double n)
        {
            Denominator = 1;
            while (n > (long)n)
            {
                n *= 10;
                Denominator *= 10;
            }
            Numerator = (long)n;
        }
        public Fraction(double n, double d)
        {
            Denominator = 1;
            while ((n > (long)n) || (d > (long)d))
            {
                n *= 10;
                d *= 10;
            }
            Numerator = (long)n;
            Denominator = (long)d;
            Fix();
        }
        /*Спрощення дробу*/
        public void Simplify()
        {
            long n = Numerator;
            long d = Denominator;
            if (n < 0 && d > 0)
            {
                n *= -1;
            }
            else
                if (n > 0 && d < 0)
            {
                d *= -1;
            }
            while ((n != 0) && (d != 0))
            {
                if (n > d)
                    n %= d;
                else
                    d %= n;
            }
            long nod = Math.Max(n, d);
            Numerator /= nod;
            Denominator /= nod;
        }
        /*Виправлення дробу*/
        public void Fix()
        {
            if ((Denominator <= 0 && Numerator <= 0) || (Denominator <= 0 && Numerator >= 0))
            {
                Denominator = -Denominator;
                Numerator = -Numerator;
            }
        }
        /*Унарні*/
        public static Fraction operator +(Fraction n)
        {
            return new Fraction(n.Numerator, n.Denominator);
        }
        public static Fraction operator -(Fraction n)
        {
            return new Fraction(-n.Numerator, n.Denominator);
        }

        /*Бінарні*/
        /*арифметичні*/
        public static Fraction operator +(Fraction n, Fraction d)
        {
            Fraction res = new Fraction(n.Numerator * d.Denominator +
                d.Numerator * n.Denominator,
                d.Denominator * n.Denominator);
            res.Simplify();
            return res;
        }
        /*+_*/
        public static Fraction operator +(Fraction n, long d)
        {
            return n + new Fraction(d);
        }
        public static Fraction operator +(long n, Fraction d)
        {
            return new Fraction(n) + d;
        }
        /*_+*/
        public static Fraction operator -(Fraction n, Fraction d)
        {
            Fraction res = new Fraction(n.Numerator * d.Denominator -
                d.Numerator * n.Denominator,
                d.Denominator * n.Denominator);
            res.Simplify();
            return res;
        }
        /*-_*/
        public static Fraction operator -(Fraction n, long d)
        {
            return n - new Fraction(d);
        }
        public static Fraction operator -(long n, Fraction d)
        {
            return new Fraction(n) - d;
        }
        /*_-*/
        public static Fraction operator *(Fraction n, Fraction d)
        {
            Fraction res = new Fraction(n.Numerator * d.Numerator,
                n.Denominator * d.Denominator);
            res.Simplify();
            return res;
        }
        /**_*/
        public static Fraction operator *(Fraction n, long d)
        {
            return n * new Fraction(d);
        }
        public static Fraction operator *(long n, Fraction d)
        {
            return new Fraction(n) * d;
        }
        /*_**/
        public static Fraction operator /(Fraction n, Fraction d)
        {
            //Fraction res = new Fraction(n.Numerator * d.Denominator,
            //    d.Numerator * n.Denominator);
            Fraction res = n * !d;
            res.Simplify();
            return res;
        }
        /*/_*/
        public static Fraction operator /(Fraction n, long d)
        {
            return n * !(new Fraction(d));
        }
        public static Fraction operator /(long n, Fraction d)
        {
            return new Fraction(n) * !d;
        }
        /*_/*/
        /*Операція приведення типу до double*/
        public static explicit operator double(Fraction n)
        {
            return (double)n.Numerator / n.Denominator;
        }
        /*порівняння*/
        public static bool operator >(Fraction n, Fraction d)
        {
            if (((n.Numerator / n.Denominator) > (d.Numerator / d.Denominator)))
                return true;
            return false;
        }
        /*>_*/
        public static bool operator >(Fraction n, double d)
        {
            if ((n.Numerator / n.Denominator) > d)
                return true;
            return false;
        }
        public static bool operator >(long n, Fraction d)
        {
            if ((double)n > (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        /*_>*/
        public static bool operator <(Fraction n, Fraction d)
        {
            if ((n.Numerator / n.Denominator) < (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        /*<_*/
        public static bool operator <(Fraction n, double d)
        {
            if ((n.Numerator / n.Denominator) < d)
                return true;
            return false;
        }
        public static bool operator <(long n, Fraction d)
        {
            if ((double)n < (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        /*_<*/
        public static bool operator ==(Fraction n, Fraction d)
        {
            if ((n.Numerator / n.Denominator) == (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        public static bool operator ==(double n, Fraction d)
        {
            if (n == (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        public static bool operator ==(Fraction n, double d)
        {
            if ((n.Numerator / n.Denominator) == d)
                return true;
            return false;
        }
        public static bool operator !=(Fraction n, Fraction d)
        {
            if ((n.Numerator / n.Denominator) != (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        public static bool operator !=(double n, Fraction d)
        {
            if (n != (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        public static bool operator !=(Fraction n, double d)
        {
            if ((n.Numerator / n.Denominator) != d)
                return true;
            return false;
        }

        /*>=_*/
        public static bool operator >=(Fraction n, Fraction d)
        {
            if ((n.Numerator / n.Denominator) >= (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        public static bool operator >=(Fraction n, double d)
        {
            if ((n.Numerator / n.Denominator) >= d)
                return true;
            return false;
        }
        public static bool operator >=(double n, Fraction d)
        {
            if (n >= (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        /*_>=*/
        /*<=_*/
        public static bool operator <=(Fraction n, Fraction d)
        {
            if ((n.Numerator / n.Denominator) >= (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        public static bool operator <=(Fraction n, double d)
        {
            if ((n.Numerator / n.Denominator) <= d)
                return true;
            return false;
        }
        public static bool operator <=(double n, Fraction d)
        {
            if (n <= (d.Numerator / d.Denominator))
                return true;
            return false;
        }
        /*_<=*/


        /*переворот дробу*/
        public static Fraction operator !(Fraction n)
        {
            Fraction res = new Fraction(n.Denominator, n.Numerator);
            res.Fix();
            return res;
        }
        /*перевизначений медод ToString*/
        public override string ToString()
        {
            string s = "Нескінченність";
            if (Denominator == 0)
                return s;
            else
                if (Numerator == 0)
                return $"({0})";
            else
                if (-1 * Numerator == Denominator || Numerator == -1 * Denominator || Numerator == Denominator)
                return $"({Numerator})";
            else
                return $"({Numerator})/({Denominator})";
        }
    }
}