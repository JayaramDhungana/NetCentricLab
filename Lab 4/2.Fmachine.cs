using System;

// Abstract class Fmachine
abstract class Fmachine
{
    // Abstract methods
    public abstract void getdata();
    public abstract void putdata();
}

// Derived class Airplane inheriting from Fmachine
class Airplane : Fmachine
{
    // Instance variables
    protected string code;
    protected string name;
    protected int capacity;

    // Implementing abstract method getdata()
    public override void getdata()
    {
        Console.Write("Enter airplane code: ");
        code = Console.ReadLine();

        Console.Write("Enter airplane name: ");
        name = Console.ReadLine();

        Console.Write("Enter airplane capacity: ");
        capacity = Convert.ToInt32(Console.ReadLine());
    }

    // Implementing abstract method putdata()
    public override void putdata()
    {
        Console.WriteLine("\nAirplane code: " + code);
        Console.WriteLine("Airplane name: " + name);
        Console.WriteLine("Airplane capacity: " + capacity);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instance of Airplane
        Airplane airplane1 = new Airplane();

        // Calling getdata() method
        airplane1.getdata();

        // Calling putdata() method
        Console.WriteLine("\nAirplane details:");
        airplane1.putdata();
    }
}
