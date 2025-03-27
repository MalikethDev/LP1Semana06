using System;
using System.Diagnostics;
using System.Threading;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            {
                // Ensure there are exactly 2 arguments provided
                if (args.Length != 2)
                {
                    Console.WriteLine("Usage: RandDice <number_of_rolls> <seed>");
                    return;
                }

                // Parse the number of rolls and seed from command line arguments
                if (!int.TryParse(args[0], out int n) || !int.TryParse(args[1], out int s))
                {
                    Console.WriteLine("Invalid input. Please provide two integers: <number_of_rolls> <seed>");
                    return;
                }

                // Initialize the random number generator with the seed
                Random rand = new Random(s);

                // Variable to hold the sum of the dice rolls
                int sum = 0;

                // Roll the dice and calculate the sum
                for (int i = 0; i < n; i++)
                {
                    // Generate a random number between 1 and 6 (inclusive)
                    sum += rand.Next(1, 7);
                }

                // Print the sum of the rolls
                Console.WriteLine(sum);
            }
        }
    }
}
