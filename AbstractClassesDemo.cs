using System;

namespace AbstractClassesDemo
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine("Abstract Classes and Methods:");
            Console.WriteLine($"Circle Area: {circle.GetArea()}"); // Output: Circle Area: 78.53981633974483
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}"); // Output: Rectangle Area: 24
        }
    }
}
