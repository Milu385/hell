using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace entregable1
{
    public class Combatsystem
    {

        List<Ienemies> Enemies;


        Random random = new Random();

        public Combatsystem()
        {

            long num = random.NextInt64(1, 3); //cambiar cantidad

            Enemies = new List<Ienemies>();


            for (int i = 0; i < num; i++)
            {
                long TipoEnemigos = random.NextInt64(1, 3);

                if (TipoEnemigos == 1)
                {
                    Enemies.Add(new Goblin(random.Next(5, 15)));
                }
                if (TipoEnemigos == 2)
                {
                    Enemies.Add(new Vampire(random.Next(10, 25)));
                }

            }

        }

        public void CombatMode(Character personaje)  //linQ para balance (dependiendo de la vida maxima cantidad de curacion)
        {

            for (double i = personaje.ShowCharacterLife(); i != 0;)
            {


                Console.WriteLine(personaje.name + " | vida = " + personaje.ShowCharacterLife());
                Console.WriteLine("\n ---------------------------------------------------------------------------------------");

                for (int j = 0; j < Enemies.Count; j++)
                {
                    if (Enemies[j].Showlife() > 0)
                    {
                        Console.WriteLine("enemigo " + j + " " + Enemies[j].GetType().Name + " || vida = " + Enemies[j].Showlife());
                    }
                    else
                    {
                        personaje.getXp(Enemies[j].getExperience());
                        Console.WriteLine("has ganado " + Enemies[j].getExperience()+ " puntos de experiencia");
                        Console.WriteLine(j + " ha muerto");
                    }
                }

                // personaje ataque

                Console.WriteLine("\n 1. atacar \n 2.curar \n 0. esperar");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);


                if (number == 1)
                {
                    Console.WriteLine(" objetivo");

                    string inputObjetivo = Console.ReadLine();
                    int objetivo;
                    Int32.TryParse(inputObjetivo, out objetivo);

                    Console.WriteLine("\n");
                    Enemies[objetivo].TakeDamageEnemy(personaje.Attack()); // controlar errores 

                }
                if (number == 2)
                {
                    double heal = random.NextInt64(0, 25);
                    Console.WriteLine("te curas " + heal + " de vida");
                    personaje.Heal(heal);
                }

                else { }


                //turno del enemigo


                int x = 0;

                if (x <= Enemies.Count)
                {
                    
                    Console.WriteLine("\n" + Enemies[x].GetType().Name + " ataca");
                    personaje.DamageTaken(Enemies[x].DamageEnemy());
                    x++;

                }
                else
                {
                    x = 0;
                }

                double win = 0;

                for (int y = 0; y < Enemies.Count; y++)
                {
                    win = Enemies[y].Showlife() + win;
                }

                if (win < 0)
                {
                    Console.WriteLine("combate finalizado | has ganado!");
                    break;
                }
                else { }

            }

            //final combate

            



        }

        public void reward(Character personaje)
        {

            long reward = random.NextInt64(1, 6);

            if (reward == 1)
            {
                Console.WriteLine("ganaste un macehete, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Machete machete = new Machete();
                    personaje.Equip(machete);

                }

            }
            if (reward == 1)
            {
                Console.WriteLine("ganaste un macehete, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Machete machete = new Machete();
                    personaje.Equip(machete);

                }
                else { }

            }
            if (reward == 2)
            {
                Console.WriteLine("ganaste un claymore, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    Claymore claymore = new Claymore();
                    personaje.Equip(claymore);

                }
                else { }



            }
            if (reward == 3)
            {
                Console.WriteLine("ganaste un armadura de cuero, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    LeatherArmor armor = new LeatherArmor();
                    personaje.Equip(armor);

                }
                else { }
            }
            if (reward == 4)
            {
                Console.WriteLine("ganaste un armadura de hierro, equipar?\n 1. si \n 2.no");

                string inputDesicion = Console.ReadLine();
                int number;
                Int32.TryParse(inputDesicion, out number);

                if (number == 1)
                {
                    PlateArmor armor = new PlateArmor();
                    personaje.Equip(armor);

                }
                else { }
            }
            if (reward == 5)
            {
                Console.WriteLine("no ganaste ninguna recompensa");
            }

        }

    }

}