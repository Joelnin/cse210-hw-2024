using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square square = new Square("Blue", 3);
        Rectangle rectangle = new Rectangle("Red", 4, 5);
        Circle circle = new Circle("Purple", 7);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
        Console.WriteLine($"The shape color is {shape.GetColor()}");
        Console.WriteLine($"The shape area is {shape.GetArea()}");
        }

        Console.WriteLine($"The square color is {square.GetColor()}");
        Console.WriteLine($"The square area is {square.GetArea()}");

        Console.WriteLine($"The rectangle color is {rectangle.GetColor()}");
        Console.WriteLine($"The rectangle area is {rectangle.GetArea()}");

        Console.WriteLine($"The circle color is {circle.GetColor()}");
        Console.WriteLine($"The circle area is {circle.GetArea()}");

    }
}