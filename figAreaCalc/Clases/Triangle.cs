using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figAreaCalc.Clases
{
    public class Triangle : iFigure
    {
        public readonly double a;
        public readonly double b;
        public readonly double c;
        public bool isSquare { get; }

        public Triangle(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
            if (a > b | a > c)
            {
                isSquare = (a * a == (b * b + c * c)) ? true : false;
                isSquare = (b * b == (a * a + c * c)) ? true : false;
                isSquare = (c * c == (b * b + a * a)) ? true : false;
            }
        }

        public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
