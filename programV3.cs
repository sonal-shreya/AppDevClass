using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Density Calculator ===");

        // Ask for mass
        Console.Write("Enter the mass of the object (in kilograms): ");
        double mass = Convert.ToDouble(Console.ReadLine());

        // Ask for volume
        Console.Write("Enter the volume of the object (in cubic meters): ");
        double volume = Convert.ToDouble(Console.ReadLine());

        // Validate volume
        if (volume <= 0)
        {
            Console.WriteLine("Error: Volume must be greater than zero.");
        }
        else
        {
            // Calculate density
            double density = mass / volume;

            // Show result
            Console.WriteLine($"The density of the object is {density} kg/m³");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
