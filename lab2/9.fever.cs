using System;

class Thermometer
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature reading in Celsius: ");
        double temperature = double.Parse(Console.ReadLine());

        if (IsFever(temperature))
        {
            Console.WriteLine("The person has a fever.");
        }
        else
        {
            Console.WriteLine("The person does not have a fever.");
        }
    }

    static bool IsFever(double temperature)
    {
        // Define the fever threshold in Celsius
        const double feverThreshold = 37.5;

        // Check if the temperature exceeds the fever threshold
        return temperature > feverThreshold;
    }
}
