using System;


namespace entregable1
{

    public class CastleRewardsFactory : AbstractRewardsFactory
    {
        private Random random = new Random();

        public void GiveRewards(Character player)
        {
            double rewardAmount = 10;
            
            player.health.Heal(rewardAmount);

            Console.WriteLine($"{player.name} ha sido recompensado con {rewardAmount} puntos de vida.");

            long reward = random.NextInt64(1, 6);

            if (reward == 1)
            {
                Console.WriteLine("ganaste una claymore, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Isword sword = new Claymore();
                    player.equipment.Equip(sword);

                }

            }
            if (reward == 2)
            {
                Console.WriteLine("ganaste un armadura de plata, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Iarmor armor = new PlateArmor();
                    player.equipment.Equip(armor);

                }
                else { }
            }

            else
            {
                Console.WriteLine("no ganaste ninguna recompensa");
            }

        
        }

    }

}
