using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Multiplication table for " + i + ":");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " * " + j + " = " + (i * j));
            }
            Console.WriteLine(); // Empty line for better readability
        }
    }
}
