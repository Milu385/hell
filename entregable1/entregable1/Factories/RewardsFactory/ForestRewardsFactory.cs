using System;


namespace entregable1
{

    public class ForestRewardsFactory : AbstractRewardsFactory
    {
        private Random random = new Random();

        public void GiveRewards(Character player)
        {
            double rewardAmount = 5;

            player.health.Heal(rewardAmount);

            Console.WriteLine($"{player.name} ha sido recompensado con {rewardAmount} puntos de vida.");

            long reward = random.NextInt64(1, 6);

            if (reward == 1)
            {
                Console.WriteLine("ganaste un machete, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Isword sword = new Machete();
                    player.equipment.Equip(sword);

                }

            }
            if (reward == 2)
            {
                Console.WriteLine("ganaste un armadura de cuero, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Iarmor armor = new LeatherArmor();
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
