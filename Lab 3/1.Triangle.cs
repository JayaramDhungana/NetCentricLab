using System;

class Triangle
{
    private double side1, side2, side3;

    public Triangle()
    {
        side1 = 3;
        side2 = 4;
        side3 = 5;
    }

    public double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }

    public double CalculateArea()
    {
        // Heron's formula to calculate the area of the triangle
        double s = CalculatePerimeter() / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        double perimeter = triangle.CalculatePerimeter();
        double area = triangle.CalculateArea();

        Console.WriteLine("Perimeter of the triangle: " + perimeter + " units");
        Console.WriteLine("Area of the triangle: " + area + " square units");
    }
}
