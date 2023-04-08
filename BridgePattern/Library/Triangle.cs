using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public class Triangle : Shape
    {
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }

        public Triangle(string color, double a, double b, double c) : base(color)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double Perimeter()
        {
            return A + B + C;
        }
    }
}
