using System;

class Program
{
    static void Main(string[] args)
    {
        CalculateTriangleArea();
        CalculateCircleArea();
        CalculateRectangleArea();

        Console.ReadLine();
    }

    static void CalculateTriangleArea()
    {
        double baseLength, height;
        Console.Write("Enter the base length of the triangle: ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseLength * height;
        Console.WriteLine("Area of the triangle: " + area);
    }

    static void CalculateCircleArea()
    {
        double radius;
        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of the circle: " + area);
    }

    static void CalculateRectangleArea()
    {
        double length, width;
        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("Area of the rectangle: " + area);
    }
}
