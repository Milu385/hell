using System;


namespace entregable1
{

    public class CastleEnemiesFactory : AbstractEnemiesFactory
    {
        private Random random = new Random();
        
        public Ienemies[] CreateEnemies()
        {
            Ienemies[] enemies = new Ienemies[random.Next(1, 3)];

            for (int i = 0; i < enemies.Length; i++)
            {
                long enemyType = random.Next(1, 4);

                if (enemyType == 1)
                {
                    enemies[i] = new Vampire(random.Next(8, 15));
                }
                else
                {
                    enemies[i] = new Sketelon(random.Next(2, 5));
                }
            }

            return enemies;
        }
    }

}

