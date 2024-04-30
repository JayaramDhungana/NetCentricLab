using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms for Fibonacci series:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci series up to " + n + " terms:");
        PrintFibonacciSeries(n);
    }

    static void PrintFibonacciSeries(int n)
    {
        int first = 0, second = 1;

        if (n >= 1)
        {
            Console.Write(first + " ");
        }
        if (n >= 2)
        {
            Console.Write(second + " ");
        }

        for (int i = 3; i <= n; i++)
        {
            int next = first + second;
            Console.Write(next + " ");

            first = second;
            second = next;
        }
    }
}
