using System;

class Circle
{
    private double radius;

    // Constructor with no arguments
    public Circle()
    {
        radius = 0; // Default radius
    }

    // Constructor with two arguments
    public Circle(double r)
    {
        radius = r;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Circle class using the constructor with two arguments
        Circle circle1 = new Circle(5.0);

        // Calculate and print the circumference
        Console.WriteLine("Circumference of circle1: " + circle1.CalculateCircumference());

        // Create an object of Circle class using the constructor with no arguments
        Circle circle2 = new Circle();

        // Set radius of circle2
        circle2 = new Circle(3.0);

        // Calculate and print the circumference
        Console.WriteLine("Circumference of circle2: " + circle2.CalculateCircumference());
    }
}
