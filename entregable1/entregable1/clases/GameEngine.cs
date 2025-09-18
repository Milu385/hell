using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace entregable1
{
    public class GameEngine
    {
        Character player;
        Combat combat;
        
        public GameEngine()
        {
            StartGame();
        }

        public void StartGame()
        {
            Console.WriteLine("Bienvenido al juego!");
            Console.WriteLine("Introduce el nombre de tu personaje:");
            string playerName = Console.ReadLine();

            // Selección del tipo de personaje
            Console.WriteLine("\nSelecciona tu clase:");
            Console.WriteLine("1. Guerrero (Vida: 30)");
            Console.WriteLine("2. Mago (Vida: 20)");
            Console.Write("Elige tu opción (1-2): ");
            
            string choice = Console.ReadLine();
            
            // Crear personaje usando Builder Pattern
            player = CreateCharacterWithBuilder(playerName, choice);
            
            // Iniciar en el estado Forest
            ICombatState initialState = new ForestCombatState();
            combat = new Combat(player, initialState);
            
            Console.WriteLine($"\n¡{player.name} el {player.type} ha sido creado!");
            Console.WriteLine($"Vida: {player.health.ShowCharacterLife()}");
            Console.WriteLine($"Daño: {player.equipment.damage()}");
            Console.WriteLine($"Ubicación: {initialState.GetName()}");
            Console.WriteLine("\nPresiona cualquier tecla para comenzar");
            Console.ReadKey();
            
            ProcessGame();
        }

        private Character CreateCharacterWithBuilder(string name, string choice)
        {
            IBuilder builder;
            
            // Seleccionar el builder apropiado
            if (choice == "2")
            {
                Console.WriteLine("Creando Mago...");
                builder = new MageBuilder();
            }
            else
            {
                Console.WriteLine("Creando Guerrero...");
                builder = new WarriorBuilder();
            }
            
            // Usar CharacterSelect como director
            CharacterSelect characterSelect = new CharacterSelect(builder);
            return characterSelect.CreateCharacter(name);
        }

        public void ProcessGame()
        {
            while (player.health.ShowCharacterLife() > 0)
            {
                Console.Clear();

                Console.WriteLine(player.name + " | vida = " + player.health.ShowCharacterLife());
                Console.WriteLine($"Ronda actual");
                Console.WriteLine("\n ---------------------------------------------------------------------------------------");

                Ienemies[] enemies = combat.GetEnemies();
                for (int j = 0; j < enemies.Length; j++)
                {
                    if (enemies[j].Showlife() > 0)
                    {
                        Console.WriteLine("enemigo " + j + " " + enemies[j].GetType().Name + " || vida = " + enemies[j].Showlife());
                    }
                    else
                    {
                        Console.WriteLine(j + " ha muerto");
                    }
                }

                combat.playerTurn();

                combat.enemyTurn();

                if (combat.checkWinCondition())
                {
                    Console.WriteLine($"\n¡Has completado la ronda!");
                    
                    combat.CompleteRound();
                }

                if (player.health.ShowCharacterLife() <= 0)
                {
                    break;
                }
                
                //Console.WriteLine("\nPresiona cualquier tecla para continuar a la siguiente ronda");
                //Console.ReadKey();
            }

            if (player.health.ShowCharacterLife() <= 0)
            {
                Console.WriteLine("has muerto");
                endGame();
            }
            else
            {
                Console.WriteLine("¡Has completado todos los estados del juego!");
                endGame();
            }
        }

        public void endGame()
        {
            Console.WriteLine("Gracias por jugar!");
            Console.WriteLine("deseas jugar de nuevo? \n 1. si \n 2. no");
            string inputDesicion = Console.ReadLine();
            int number;
            Int32.TryParse(inputDesicion, out number);
            if (number == 1)
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("Hasta luego!");
                Environment.Exit(0);
            }
        }
    }
}