using System;

class Car
{
    public string CarModel { get; set; }
    public string CarName { get; set; }
    public double CarPrice { get; set; }
    public string CarOwner { get; set; }

    public void SetCarData()
    {
        Console.Write("Enter Car Model: ");
        CarModel = Console.ReadLine();

        Console.Write("Enter Car Name: ");
        CarName = Console.ReadLine();

        Console.Write("Enter Car Price: $");
        CarPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter Car Owner: ");
        CarOwner = Console.ReadLine();
    }

    public void DisplayCarData()
    {
        Console.WriteLine("Car Model: " + CarModel);
        Console.WriteLine("Car Name: " + CarName);
        Console.WriteLine("Car Price: $" + CarPrice);
        Console.WriteLine("Car Owner: " + CarOwner);
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Console.WriteLine("Enter details for Car 1:");
        car1.SetCarData();

        Car car2 = new Car();
        Console.WriteLine("Enter details for Car 2:");
        car2.SetCarData();

        Car car3 = new Car();
        Console.WriteLine("Enter details for Car 3:");
        car3.SetCarData();

        Console.WriteLine("Car 1:");
        car1.DisplayCarData();

        Console.WriteLine("Car 2:");
        car2.DisplayCarData();

        Console.WriteLine("Car 3:");
        car3.DisplayCarData();
    }
}
