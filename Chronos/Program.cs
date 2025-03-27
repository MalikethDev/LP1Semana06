using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create new Stopwatch instances
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // Start the first stopwatch
            crono1.Start();
            Console.WriteLine("Crono 1 started...");

            // Pause for 500 milliseconds
            Thread.Sleep(500);
            Console.WriteLine("Crono 1 paused for 500 milliseconds...");

            // Start the second stopwatch
            crono2.Start();
            Console.WriteLine("Crono 2 started...");

            // Pause for 0.25 seconds
            Thread.Sleep(250);
            Console.WriteLine("Crono 2 paused for 250 milliseconds...");

            // Stop both stopwatches
            crono1.Stop();
            crono2.Stop();

            // Display elapsed time for both stopwatches in seconds with 4 decimal places
            Console.WriteLine($"Crono 1 elapsed time: {crono1.Elapsed.TotalSeconds:F4} seconds");
            Console.WriteLine($"Crono 2 elapsed time: {crono2.Elapsed.TotalSeconds:F4} seconds");
        }
    }
}
