using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 5, 7, 3, 15, 20, 2, 8 }; // Example array

        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }

            if (number < smallest)
            {
                smallest = number;
            }
        }

        Console.WriteLine("The largest element in the array is: " + largest);
        Console.WriteLine("The smallest element in the array is: " + smallest);
    }
}
