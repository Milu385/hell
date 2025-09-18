// Combat.cs (corregido)
namespace entregable1
{
    public class Combat : ICombat
    {
        private Ienemies[] enemies;
        private Random random = new Random();
        private Character player;
        private ICombatState currentState;
        private int rounds;
        private bool roundCompleted;

        public Combat(Character player, ICombatState initialState)
        {
            this.player = player;
            this.currentState = initialState;
            this.enemies = currentState.GenerateEnemies();
            this.rounds = 0;
            this.roundCompleted = false;
        }
        
        public void ChangeState(ICombatState newState)
        {
            this.currentState = newState;
            this.enemies = currentState.GenerateEnemies();
            this.rounds = 0;
            this.roundCompleted = false;
            Console.WriteLine($"\n¡Has llegado al {newState.GetName()}!");
        }
        
        public void CompleteRound()
        {
            rounds++;
            roundCompleted = true;
            Console.WriteLine($"\n--- Ronda {rounds} completada ---");
            
            // Aplicar recompensas del estado actual
            currentState.GenerateRewards(player);
            
            // Manejar finalización de ronda
            currentState.HandleRoundCompletion(this);
        }

        public void SetEnemies(Ienemies[] enemies)
        {
            this.enemies = enemies;
        }
        
        public Ienemies[] GetEnemies()
        {
            return enemies;
        }

        public int GetCurrentRound()
        {
            return rounds;
        }

        public void playerTurn()
        {
            Console.WriteLine("\n 1. atacar \n 2. curar \n 0. esperar");

            string inputDesicion = Console.ReadLine();
            int number;
            Int32.TryParse(inputDesicion, out number);

            if (number == 1)
            {
                Console.WriteLine("Selecciona objetivo (0-" + (enemies.Length - 1) + "):");
                
                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i].Showlife() > 0)
                    {
                        Console.WriteLine($"{i}. {enemies[i].GetType().Name} (Vida: {enemies[i].Showlife()})");
                    }
                    else
                    {
                        Console.WriteLine($"{i}. {enemies[i].GetType().Name} [MUERTO]");
                    }
                }

                string inputObjetivo = Console.ReadLine();
                int objetivo;
                if (Int32.TryParse(inputObjetivo, out objetivo) && objetivo >= 0 && objetivo < enemies.Length)
                {
                    if (enemies[objetivo].Showlife() > 0)
                    {
                        double damage = player.Attack();
                        if (damage > 0)
                        {
                            enemies[objetivo].TakeDamageEnemy(damage);
                            //Console.WriteLine($"Has hecho {damage} de daño al enemigo {objetivo}");
                            
                            // Verificar si el enemigo murió
                            if (enemies[objetivo].Showlife() <= 0)
                            {
                                Console.WriteLine($"¡Enemigo {objetivo} derrotado!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Este enemigo ya está derrotado");
                    }
                }
                else
                {
                    Console.WriteLine("Objetivo inválido");
                }
            }
            else if (number == 2)
            {
                double heal = random.Next(0, 25);
                Console.WriteLine("Te curas " + heal + " de vida");
                player.health.Heal(heal);
            }
            else
            {
                Console.WriteLine("Esperas este turno");
            }

            Thread.Sleep(1000);
        }

        public void enemyTurn()
        {
            Console.WriteLine("\n--- Turno de los enemigos ---");
            
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i].Showlife() > 0)
                {
                    Console.WriteLine($"{enemies[i].GetType().Name} ataca!");
                    double damage = enemies[i].DamageEnemy();
                    player.TakeDamage(damage);
                    Console.WriteLine($"Recibes {damage} de daño");
                    
                    Thread.Sleep(500);
                }
            }
            
            Thread.Sleep(1000);
        }

        public bool checkWinCondition()
        {
            return currentState.CheckWinCondition(this);
        }

        public bool AreAllEnemiesDefeated()
        {
            foreach (var enemy in enemies)
            {
                if (enemy.Showlife() > 0)
                    return false;
            }
            return true;
        }
    }
}