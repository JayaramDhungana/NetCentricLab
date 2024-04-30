using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

        double largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine("The largest number is: " + largest);
    }
}
