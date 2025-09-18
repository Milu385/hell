using System;


namespace entregable1
{

    public class ForestEnemiesFactory : AbstractEnemiesFactory
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
                    enemies[i] = new Troll(random.Next(10, 15));
                }
                else
                {
                    enemies[i] = new Goblin(random.Next(4, 8));
                }
            }

            return enemies;
        }
    }

}

