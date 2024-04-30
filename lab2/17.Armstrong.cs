using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsArmstrong(number))
        {
            Console.WriteLine("The number is an Armstrong number.");
        }
        else
        {
            Console.WriteLine("The number is not an Armstrong number.");
        }
    }

    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int numDigits = CountDigits(number);
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numDigits);
            number /= 10;
        }

        return originalNumber == sum;
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
}
