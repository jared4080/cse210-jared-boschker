using System;
using System.Globalization;
using Leanring05;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle circle = new Circle("red", 5.0);
        shapes.Add(circle);
        
        Square square = new Square("terracota", 3.0);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("charcol", 4.6, 2.0);
        shapes.Add(rectangle);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"the area of the shape is {area}. it's also {color} btw");
        }
    }
}