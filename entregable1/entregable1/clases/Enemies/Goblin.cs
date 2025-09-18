using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{
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
            else { Console.WriteLine("el goblin falla!"); return 0; }  
   
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

