using System;

class SI
{
    static void Main(string[] args)
    {
        double principal, rate, time, simpleInterest;

        // Input principal amount
        Console.Write("Enter the principal amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        // Input rate of interest
        Console.Write("Enter the rate of interest (in percentage): ");
        rate = Convert.ToDouble(Console.ReadLine());

        // Input time period
        Console.Write("Enter the time period (in years): ");
        time = Convert.ToDouble(Console.ReadLine());

        // Calculate simple interest
        simpleInterest = (principal * rate * time) / 100;

        // Display the result
        Console.WriteLine("Simple Interest ="+ simpleInterest);

        Console.ReadLine();
    }
}
