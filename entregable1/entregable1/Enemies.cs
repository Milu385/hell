using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{

    public interface Ienemies
    {
        void TakeDamageEnemy(double Damage);

        double DamageEnemy();

        double Showlife();


    }



    public class Goblin : Ienemies
    {
        private double lifeEnemy;

        Random random = new Random(); 

        public Goblin(double lifeEnemy)
        {
            this.lifeEnemy = lifeEnemy;
        }

        double Ienemies.DamageEnemy()
        {

            long HitOrMiss = random.NextInt64(1, 3);

            if (HitOrMiss == 1) { return 2; }
            else { Console.WriteLine("goblin misses"); return 0; }  
   
        }

        void Ienemies.TakeDamageEnemy(double Damage)
        {
            lifeEnemy -= Damage;
        }

        double Ienemies.Showlife()
        {
            return lifeEnemy; 
        }
        

}




        public class Vampire : Ienemies
        {
            private double lifeEnemy;

            Random random = new Random();

            public Vampire(double lifeEnemy)
            {
                this.lifeEnemy = lifeEnemy;
            }

            double Ienemies.DamageEnemy()
            {

            long HitOrMiss = random.NextInt64(1, 5);

            if (HitOrMiss == 1) { lifeEnemy += 1; return 3; }
            else { Console.WriteLine("vampire misses"); return 0; }
                
            }

            void Ienemies.TakeDamageEnemy(double Damage)
            {
                lifeEnemy -= Damage;
            }

            double Ienemies.Showlife()
            {
            return lifeEnemy;
            }

        }

    }

