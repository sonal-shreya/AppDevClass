using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Multi-Program Runner ===");
        Console.WriteLine("1. Maximum Heart Rate Calculator");
        Console.WriteLine("2. Density Calculator");
        Console.WriteLine("3. Square Perimeter Calculator");
        Console.Write("Choose which program to run (1-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RunHeartRateCalculator();
                break;
            case "2":
                RunDensityCalculator();
                break;
            case "3":
                RunSquarePerimeterCalculator();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // --- Version 1: Heart Rate ---
    static void RunHeartRateCalculator()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int maxHeartRate = 220 - age;
        Console.WriteLine($"Your estimated Maximum Heart Rate is: {maxHeartRate} bpm");
    }

    // --- Version 2: Density ---
    static void RunDensityCalculator()
    {
        Console.WriteLine("=== Density Calculator ===");

        Console.Write("Enter the mass of the object (in kilograms): ");
        double mass = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the volume of the object (in cubic meters): ");
        double volume = Convert.ToDouble(Console.ReadLine());

        if (volume <= 0)
        {
            Console.WriteLine("Error: Volume must be greater than zero.");
        }
        else
        {
            double density = mass / volume;
            Console.WriteLine($"The density of the object is {density} kg/m³");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // --- Version 3: Square Perimeter ---
    static void RunSquarePerimeterCalculator()
    {
        Console.Write("Enter the side length of the square: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double side) && side >= 0)
        {
            double perimeter = 4 * side;
            Console.WriteLine($"Perimeter = 4 × {side} = {perimeter}");
        }
        else
        {
            Console.WriteLine("Please enter a non-negative number (use '.' as the decimal separator).");
        }
    }
}
