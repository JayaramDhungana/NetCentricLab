using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("The number is a palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not a palindrome.");
        }
    }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }
}
