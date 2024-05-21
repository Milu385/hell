using hell;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public TaskCompletionSource<bool> buttonActionClick;

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


        public void DamageEnemy(Character character, int x)
        {
            if (x <= Enemies.Count)
            {
                Enemies[x].TakeDamageEnemy(character.Attack());
            }
            else { }

        }



        public async void CombatMode(Character personaje, Form2 form)  //linQ para balance (dependiendo de la vida maxima cantidad de curacion)
        {
            Dictionary<int, PictureBox> goblinImage = new();

            goblinImage.Add(0, form.pictureGoblin1);
            goblinImage.Add(1, form.pictureGoblin2);
            goblinImage.Add(2, form.pictureGoblin3);
            goblinImage.Add(3, form.pictureGoblin4);
            goblinImage.Add(4, form.pictureGoblin5);

            Dictionary<int, PictureBox> vampireImage = new();

            vampireImage.Add(0, form.pictureVampire1);
            vampireImage.Add(1, form.pictureVampire2);
            vampireImage.Add(2, form.pictureVampire3);
            vampireImage.Add(3, form.pictureVampire4);
            vampireImage.Add(4, form.pictureVampire5);

            Dictionary<int, TextBox> enemyInfoText = new();

            enemyInfoText.Add(0, form.EnemyInfo1);
            enemyInfoText.Add(1, form.EnemyInfo2);
            enemyInfoText.Add(2, form.EnemyInfo3);
            enemyInfoText.Add(3, form.EnemyInfo4);
            enemyInfoText.Add(4, form.EnemyInfo5);






            for (double i = personaje.ShowCharacterLife(); i > 0;)
            {
                Thread.Sleep(1500);

                buttonActionClick = new TaskCompletionSource<bool>();

                form.heroInfo.Text = "";
                form.EnemyInfo1.Text = "";
                form.EnemyInfo2.Text = "";
                form.EnemyInfo3.Text = "";
                form.EnemyInfo4.Text = "";
                form.EnemyInfo5.Text = "";



                form.heroInfo.Text = personaje.name + " | vida = " + personaje.ShowCharacterLife();


                for (int j = 0; j < Enemies.Count; j++)
                {

                    if (Enemies[j].Showlife() > 0)
                    {

                        if (Enemies[j].GetType().Name == "Goblin") { goblinImage[j].Visible = true; }
                        else
                        {
                            vampireImage[j].Visible = true;
                        }


                        enemyInfoText[j].Text = ("enemigo " + j + " " + Enemies[j].GetType().Name + " || vida = " + Enemies[j].Showlife());
                    }
                    else
                    {
                        personaje.getXp(Enemies[j].getExperience());

                        enemyInfoText[j].Text = " ha muerto";
                    }
                }

                // personaje ataque

                form.buttonAttack.Enabled = true;
                form.buttonHeal.Enabled = true;

                await buttonActionClick.Task;

                form.buttonAttack.Enabled = false;
                form.buttonHeal.Enabled = false;




                //turno del enemigo

                int x = 0;

                if (x <= Enemies.Count)
                {
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
                    form.heroInfo.Text = "";
                    form.heroInfo.Text = ("combate finalizado | has ganado!");
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