using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }

    static long CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }

        if (number == 0 || number == 1)
        {
            return 1;
        }

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
