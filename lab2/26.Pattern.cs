using System;

class Program
{
    static void Main()
    {
        // Define the number of rows for the pattern
        int rows = 5;

        // Loop to print the pattern three times
        for (int k = 0; k < 2; k++)
        {
            // Loop to print increasing number of asterisks
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Separate the patterns with a newline
            Console.WriteLine();
        }
        Console.Write("*");
    }
}
