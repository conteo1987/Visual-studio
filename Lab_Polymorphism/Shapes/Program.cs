using System;

public class Program
{
    public static void Main()
    {
        
        Circle circle = new Circle(10);
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.CalculateArea());



        Rectangle rectangle = new Rectangle(4.3, 4.7);
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(rectangle.CalculateArea());

    }
}