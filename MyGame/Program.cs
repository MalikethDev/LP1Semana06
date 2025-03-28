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

            // Create an array with capacity for the number of enemies
            Enemy[] enemiesArray = new Enemy[numberOfEnemies];
            Random random = new Random(); // Random number generator

            // Ask the user for enemy names
            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.Write($"Enter name for enemy {i + 1}: ");
                string name = Console.ReadLine();
                enemiesArray[i] = new Enemy(name);
            }

            // Ensure the names don't exceed 8 characters
            if (enemiesArray[0].GetName().Length > 8)
            {
                Console.WriteLine("Error: Name cannot exceed 8 characters.");
                return;
            }

            // Create the enemy objects
            for (int i = 0; i < numberOfEnemies; i++)
            {
                enemiesArray[i] = new Enemy(enemiesArray[i].GetName());
            }

            // After inserting all names, print the names, health and shield of each enemy
            Console.WriteLine("\nEnemies created:");
            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.WriteLine($"Enemy {i + 1}: Name: {enemiesArray[i].GetName()}, Health: {enemiesArray[i].GetHealth()}, Shield: {enemiesArray[i].GetShield()}");
            }

            // Randomly pick up power-ups for each enemy
            for (int i = 0; i < numberOfEnemies; i++)
            {
                // Randomly choose a power-up type
                PowerUp powerUp = (PowerUp)random.Next(0, 2); // 0 for Health, 1 for Shield
                float amount = random.Next(1, 100); // Random amount between 1 and 100

                // Pick up the power-up
                enemiesArray[i].PickUpPowerUp(powerUp, amount);

                // Print the updated health and shield after picking up the power-up
                Console.WriteLine($"Enemy {i + 1} picked up a {powerUp} power-up of amount {amount}. Updated Health: {enemiesArray[i].GetHealth()}, Shield: {enemiesArray[i].GetShield()}");
            }
        }
    }
}
