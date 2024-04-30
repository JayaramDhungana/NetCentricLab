using System;

class OddOrEven
{
    public static void Main(string[] args)
    {
        int n1;
        int n2;
        Console.WriteLine("Please enter a number to check if it's odd or even:");
        n1 = int.Parse(Console.ReadLine());

        n2 = n1 % 2;

        if (n2 == 0)
        {
            Console.WriteLine(n1 + " is an even number");
        }
        else
        {
            Console.WriteLine(n1 + " is an odd number.");
        }

        Console.ReadKey();
    }
}
