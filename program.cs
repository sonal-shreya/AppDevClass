using System;
using System.Linq;

class Program
{
    static int CountLetters(string s) => s.Count(char.IsLetter);

    static void Main(string[] args)
    {
        string input;

        if (args.Length > 0)
        {
            // Allow passing the sentence as command-line args
            input = string.Join(" ", args);
        }
        else
        {
            Console.Write("Enter a sentence: ");
            input = Console.ReadLine() ?? string.Empty;
        }
        
        int letterCount = CountLetters(input);
        Console.WriteLine($"Number of letters: {letterCount}");
    }
}
