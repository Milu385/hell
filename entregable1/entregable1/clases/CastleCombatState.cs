// CastleCombatState.cs (corregido)
namespace entregable1
{
    public class CastleCombatState : ICombatState
    {
        private AbstractEnemiesFactory enemiesFactory;
        private AbstractRewardsFactory rewardsFactory;
        
        public CastleCombatState()
        {
            enemiesFactory = new CastleEnemiesFactory();
            rewardsFactory = new CastleRewardsFactory();
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
            return "Castle";
        }
        
        public void HandleRoundCompletion(Combat combat)
        {
            if (combat.AreAllEnemiesDefeated())
            {
                Console.WriteLine("¡Todos los enemigos derrotados! Has conquistado el castillo.");
                // Aquí podrías cambiar a otro estado o finalizar el juego
            }
            else
            {
                Console.WriteLine("Continúa la batalla en el castillo...");
            }
        }
    }
}