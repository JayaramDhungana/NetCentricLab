using System;

class Program
{
    static void Main(string[] args)
    {
        // Define an integer array of size 20
        int[] numbers = new int[20];

        // Populate the array with random numbers
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); // Generate random numbers between 1 and 100
        }

        // Print the original array
        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        // Find and print even numbers
        Console.WriteLine("\nEven Numbers:");
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
            }
        }

        // Find and print odd numbers
        Console.WriteLine("\n\nOdd Numbers:");
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }
    }

    // Method to print an array
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
