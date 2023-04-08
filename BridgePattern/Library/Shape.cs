using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public abstract double Area();

        public abstract double Perimeter();
    }
}
