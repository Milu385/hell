namespace entregable1
{
    public interface ICombatState
    {
        Ienemies[] GenerateEnemies();
        void GenerateRewards(Character player);
        bool CheckWinCondition(Combat combat);
        string GetName();
        void HandleRoundCompletion(Combat combat);
    }
}