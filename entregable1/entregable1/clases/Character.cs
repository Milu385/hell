using System;

namespace entregable1
{
    public class Character
    {
        public string name { get; set; }
        public string type { get; set; }
        public IHealthManager health { get; set; }
        public IequipmentManager equipment { get; set; }
        Random random = new Random();
        
        public void TakeDamage(double baseDamage)
        {
            double resistencia = equipment.resistencia();
            double damageFinal = baseDamage * resistencia;
            health.takeDamage(damageFinal);
        }

        public double Attack()
        {
            long HitOrMiss = random.NextInt64(1, 5);

            if (HitOrMiss == 1) { Console.WriteLine("has fallado!"); return 0; }
            else { Console.WriteLine("has hecho " + equipment.damage() + " de daño"); return equipment.damage(); }

        }

    }
}