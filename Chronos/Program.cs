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

            // Start the second stopwatch
            crono2.Start();
            Console.WriteLine("Crono 2 started...");

            // Pause for 500 milliseconds
            Thread.Sleep(500);
            Console.WriteLine("Crono 1 paused for 500 milliseconds...");
        }
    }
}
