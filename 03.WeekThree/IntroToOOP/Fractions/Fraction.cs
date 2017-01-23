using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        private double numerator;
        private double denominator;

        public Fraction(double numerator, double denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public double Denominator
        {
            get
            {
                return this.denominator;
            }
            private  set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }
                this.denominator = value;                
            }
        }

        public double Numerator
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                this.numerator = value;
            }
        }

        public override string ToString()
        {
            string result = this.denominator + "/" + this.numerator;

            return result;
        }

        public override bool Equals(object obj)
        {
            if (this.denominator == (obj as Fraction).denominator && this.numerator == (obj as Fraction).numerator)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Fraction obj1, Fraction obj2)
        {
            if (obj1.denominator == obj2.denominator && obj1.numerator == obj2.numerator)
	        {
		        return true;
	        }

            return false;
        }

        public static bool operator !=(Fraction obj1, Fraction obj2)
        {
            if (obj1.numerator != obj2.numerator && obj1.denominator != obj2.denominator)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + denominator.GetHashCode();
                hash = hash * 23 + numerator.GetHashCode();
                return hash;
            }
        }

        public static double operator +(Fraction obj1, Fraction obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            double result = (obj1.numerator * obj2.denominator  + obj2.numerator * obj1.denominator) / lcm;
            return result;
        }

        public static double operator -(Fraction obj1, Fraction obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            double result = (obj1.numerator * obj2.denominator - obj2.numerator * obj1.denominator) / lcm;
            return result;
        }

        public static double operator *(Fraction obj1, Fraction obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            double result = (obj1.numerator * obj2.numerator) / lcm;

            return result;
        }

        public static double operator /(Fraction obj1, Fraction obj2)
        {
            double numer = obj1.numerator * obj2.denominator;
            double denom = obj1.denominator * obj2.numerator;

            return numer / denom;
        }

        public static double operator +(Fraction obj1, double number)
        {
            double result = obj1.numerator / obj1.denominator + number;

            return result;
        }

        public static double operator -(Fraction obj1, double number)
        {
            double result = obj1.numerator / obj1.denominator - number;

            return result;
        }

        public static double operator *(Fraction obj1, double number)
        {
            double result = obj1.numerator * obj1.denominator * number;

            return result;
        }

        public static double operator /(Fraction obj1, double number)
        {
            double result = (obj1.numerator / obj1.denominator) / number;

            return result;
        }

        public static explicit operator double(Fraction obj1)
        {
            return obj1.numerator / obj1.denominator;
        }
    }
}
