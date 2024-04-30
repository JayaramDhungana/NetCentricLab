using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int reverseNumber = ReverseNumber(number);
        Console.WriteLine("Reverse of the given number is: " + reverseNumber);
    }

    static int ReverseNumber(int number)
    {
        int reverse = 0;
        while (number > 0)
        {
            int digit = number % 10; // Extract the last digit
            reverse = reverse * 10 + digit; // Append the digit to the reverse number
            number /= 10; // Remove the last digit from the original number
        }
        return reverse;
    }
}
