using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width)
        { }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
