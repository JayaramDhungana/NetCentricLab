using System;

class Rectangle
{
    private double length;
    private double breadth;

    // Constructor
    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    // Method to compute area
    public double ComputeArea()
    {
        return length * breadth;
    }

    // Method to display area
    public void DisplayArea()
    {
        Console.WriteLine("Area of rectangle: " + ComputeArea());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter dimensions for rectangle 1:");
        Console.Write("Length: ");
        double length1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Breadth: ");
        double breadth1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter dimensions for rectangle 2:");
        Console.Write("Length: ");
        double length2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Breadth: ");
        double breadth2 = Convert.ToDouble(Console.ReadLine());

        // Create two Rectangle objects
        Rectangle rectangle1 = new Rectangle(length1, breadth1);
        Rectangle rectangle2 = new Rectangle(length2, breadth2);

        // Find areas of rectangles
        double area1 = rectangle1.ComputeArea();
        double area2 = rectangle2.ComputeArea();

        // Display areas of rectangles
        Console.WriteLine("\nArea of rectangle 1: " + area1);
        Console.WriteLine("Area of rectangle 2: " + area2);

        // Display area of larger rectangle
        if (area1 > area2)
        {
            Console.WriteLine("\nArea of larger rectangle: " + area1);
        }
        else if (area2 > area1)
        {
            Console.WriteLine("\nArea of larger rectangle: " + area2);
        }
        else
        {
            Console.WriteLine("\nBoth rectangles have the same area.");
        }
    }
}
