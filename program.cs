using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
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
}
