using System;

class Program
{
    static void Main()
    {
        // Define an array
        int[] array = { 5, 10, 15, 20, 25 };

        // Declare variables for sum and average
        int sum;
        double average;

        // Call the method to find sum and average
        FindSumAndAverage(array, out sum, out average);

        // Print sum and average
        Console.WriteLine("Sum of array elements: " + sum);
        Console.WriteLine("Average of array elements: " + average);
    }

    static void FindSumAndAverage(int[] arr, out int sum, out double average)
    {
        // Initialize sum to 0
        sum = 0;

        // Calculate sum of array elements
        foreach (int num in arr)
        {
            sum += num;
        }

        // Calculate average
        average = (double)sum / arr.Length;
    }
}
