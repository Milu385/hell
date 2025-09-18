using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{
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
            else { Console.WriteLine("el vampiro falla!"); return 0; }

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