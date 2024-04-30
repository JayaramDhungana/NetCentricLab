using System;

class Number
{
    private int x;
    private int y;
    private int z;

    // Constructor to initialize instance variables
    public Number(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Method to get the maximum number
    public int GetMax()
    {
        return Math.Max(Math.Max(x, y), z);
    }
}

class NumberDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");

        // Take user input for three numbers
        Console.Write("Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 3: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Create an object of Number class with user input
        Number number = new Number(num1, num2, num3);

        // Get and print the largest number
        int maxNumber = number.GetMax();
        Console.WriteLine("The largest number is: " + maxNumber);
    }
}
