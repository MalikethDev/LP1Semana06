using System;
using System.Collections.Generic;

namespace MyGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ensure one argument is passed (number of enemies)
            if (args.Length != 1 || !int.TryParse(args[0], out int numberOfEnemies) || numberOfEnemies <= 0)
            {
                Console.WriteLine("Usage: MyGame <number_of_enemies>");
                return;
            }

            // Create a list of enemies
            List<Enemy> enemies = new List<Enemy>();

            // Create enemies with default names
            for (int i = 0; i < numberOfEnemies; i++)
            {
                Enemy enemy = new Enemy($"Enemy {i + 1}");
                enemies.Add(enemy);
            }

            // Print the names of the enemies
            Console.WriteLine($" {numberOfEnemies} created:");
        }
    }
}
