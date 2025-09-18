using System;

namespace entregable1
{
    public class healthManager : IHealthManager
    {

        private double maxHealth;

        private double currentHealth;


        public healthManager(double health)
        {
            maxHealth = health;
            currentHealth = maxHealth;
        }

        public void Heal(double heal)
        {
            currentHealth += heal;
        }


        public void takeDamage(double damage)
        {
            currentHealth -= damage;
        }
        
        public double ShowCharacterLife()
        {
            return currentHealth;
        }

    }

}