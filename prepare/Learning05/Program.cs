using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 4);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("purple", 4, 2);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("green", 4);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>()
        {
            square, rectangle, circle
        };
        
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}  Area: {s.GetArea()}");
        }
    }
}