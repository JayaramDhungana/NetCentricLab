using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        // Check divisibility from 2 to square root of the number
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                // If the number is divisible by any number between 2 and its square root, it's not prime
                return false;
            }
        }

        // If the loop completes without finding a divisor, the number is prime
        return true;
    }
}
