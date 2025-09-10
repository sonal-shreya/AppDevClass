using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int maxHeartRate = 220 - age;
        Console.WriteLine($"Your estimated Maximum Heart Rate is: {maxHeartRate} bpm");
    }
}

