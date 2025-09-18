using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{
    public class Troll : Ienemies
    {
        private double lifeEnemy;

        Random random = new Random(); 

        public Troll(double lifeEnemy)
        {
            this.lifeEnemy = lifeEnemy;
        }

        double Ienemies.DamageEnemy()
        {

            long HitOrMiss = random.NextInt64(1, 8);

            if (HitOrMiss == 1) { return 8; }
            else { Console.WriteLine("el troll falla!"); return 0; }  
   
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

