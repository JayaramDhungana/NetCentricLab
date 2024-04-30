using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Even numbers between 1 and 500:");
        for (int i = 2; i <= 500; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\n\nOdd numbers between 1 and 500:");
        for (int i = 1; i <= 500; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}
