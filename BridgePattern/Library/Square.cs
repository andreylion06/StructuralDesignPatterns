using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(string color, double side) : base(color)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}
