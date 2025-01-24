using System;

namespace wk2ex1
{
    internal class Program
    {
        static void Main()
        {
            // Ask the user to input their overall score
            Console.Write("What is a numeric score (0 to 100)? ");
            // Convert to double and wait for user input
            double score = double.Parse(Console.ReadLine());
            
            // Determine the letter grade based on the score
            if (score >= 89.5)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 79.5)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 69.5)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 59.5)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        Console.ReadLine();
        }
    }
}

