// ForestCombatState.cs (corregido)
namespace entregable1
{
    public class ForestCombatState : ICombatState
    {
        private AbstractEnemiesFactory enemiesFactory;
        private AbstractRewardsFactory rewardsFactory;
        private int roundsSurvived;
        
        public ForestCombatState()
        {
            enemiesFactory = new ForestEnemiesFactory();
            rewardsFactory = new ForestRewardsFactory();
            roundsSurvived = 0;
        }
        
        public Ienemies[] GenerateEnemies()
        {
            return enemiesFactory.CreateEnemies();
        }
        
        public void GenerateRewards(Character player)
        {
            rewardsFactory.GiveRewards(player);
        }
        
        public bool CheckWinCondition(Combat combat)
        {
            return combat.AreAllEnemiesDefeated();
        }
        
        public string GetName()
        {
            return "Bosque";
        }
        
        public void HandleRoundCompletion(Combat combat)
        {
            roundsSurvived++;
            Console.WriteLine($"Rondas sobrevividas en el bosque: {roundsSurvived}/3");
            
            
            if (roundsSurvived >= 3)
            {
                Console.WriteLine("¡Has sobrevivido 3 rondas en el bosque! Avanzas al castillo.");
                combat.ChangeState(new CastleCombatState());
            }
            else
            {
                combat.SetEnemies(GenerateEnemies());
            }
        }
    }
}