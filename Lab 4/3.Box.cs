using System;

// Parent class Box
class Box
{
    protected double length;
    protected double breadth;
    protected double height;

    // Constructor to initialize dimensions
    public Box(double length, double breadth, double height)
    {
        this.length = length;
        this.breadth = breadth;
        this.height = height;
    }

    // Method to compute volume
    public double GetVolume()
    {
        return length * breadth * height;
    }
}

// Subclass BoxWeight inheriting from Box
class BoxWeight : Box
{
    private double weight;

    // Constructor calling superclass constructor using base keyword
    public BoxWeight(double length, double breadth, double height, double weight) : base(length, breadth, height)
    {
        this.weight = weight;
    }

    // Method to set weight
    public void SetWeight(double weight)
    {
        this.weight = weight;
    }

    // Method to get weight
    public double GetWeight()
    {
        return weight;
    }
}

// Class BoxDemo with main method
class BoxDemo
{
    static void Main(string[] args)
    {
        // Creating objects of BoxWeight
        BoxWeight box1 = new BoxWeight(10, 5, 3, 2.5);
        BoxWeight box2 = new BoxWeight(8, 4, 6, 3.8);

        // Displaying volumes and weights of both boxes
        Console.WriteLine("Box 1 - Volume: " + box1.GetVolume() + " Weight: " + box1.GetWeight());
        Console.WriteLine("Box 2 - Volume: " + box2.GetVolume() + " Weight: " + box2.GetWeight());
    }
}
