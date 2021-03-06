using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Circle : Shape
    {
        public Circle(double radius, double width) : base(radius, width)
        {
            Width = Height;
        }

        public override double CalculateSurface()
        {
            return 3.14 * Height * Width;
        }
    }
}
