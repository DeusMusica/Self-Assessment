using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(50, 2);
            Console.WriteLine(t.CalculateSurface());
            Rectangle r = new Rectangle(50, 2);
            Console.WriteLine(r.CalculateSurface());
            Circle c = new Circle(1, 1);
            Console.WriteLine(c.CalculateSurface());
        }
    }
}
