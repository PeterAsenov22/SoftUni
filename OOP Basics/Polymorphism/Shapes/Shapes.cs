using System;

public class Shapes
{
    public static void Main()
    {
        Shape circle = new Circle(2.5);
        Shape rectangle = new Rectangle(5.5, 4);

        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.Draw());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.Draw());
    }
}

