using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyGame // Ensure this matches Program.cs
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        // Constructor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        // Set name (max 8 characters)
        public void SetName(string name)
        {
            if (name.Length > 8)
            {
                throw new ArgumentException("Name cannot exceed 8 characters.");
            }
            this.name = name;
        }

        // Get name
        public string GetName()
        {
            return name;
        }

        // Get health
        public float GetHealth()
        {
            return health;
        }

        // Get shield
        public float GetShield()
        {
            return shield;
        }

        // PickUpPowerUp method
        public void PickUpPowerUp(PowerUp powerUp, float amount)
        {
            if (powerUp == PowerUp.Health)
            {
                health += amount; // Increase health by the specified amount
                if (health > 100) // Ensure health does not exceed 100
                {
                    health = 100;
                }
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += amount; // Increase shield by the specified amount
                if (shield > 100) // Ensure shield does not exceed 100
                {
                    shield = 100;
                }
            }
        }

        // TakeDamage method
        public void TakeDamage(float damage)
        {
            if (shield > 0)
            {
                shield -= damage; // Reduce shield first
                if (shield < 0) // If shield goes below 0, reduce health
                {
                    health += shield; // Add the negative value of shield to health
                    shield = 0; // Set shield to 0
                }
            }
            else
            {
                health -= damage; // Reduce health directly if no shield
                if (health < 0) // Ensure health does not go below 0
                {
                    health = 0;
                }
            }
        }
    }
}