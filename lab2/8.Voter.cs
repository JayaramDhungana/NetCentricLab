using System;

class voter{
    public static void Main(string[] args)
    {
        int age;
        Console.WriteLine("What is your age?");
        age = int.Parse(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine("You are voter.");
        }
        else{
            Console.WriteLine("You are not eligible for vote.");
        }
        Console.ReadKey();
    }
}