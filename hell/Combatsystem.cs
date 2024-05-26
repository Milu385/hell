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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace entregable1
{
    public class Combatsystem
    {

        List<Ienemies> Enemies;

        public TaskCompletionSource<bool> buttonActionClick;

        Random random = new Random();

        public int healLimit;                   

        public Combatsystem()
        {

            long num = random.NextInt64(1, 2); 

            Enemies = new List<Ienemies>();


            for (int i = 0; i < num; i++)
            {
                long TipoEnemigos = random.NextInt64(1, 3);                 //crea la lista de enemigos

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
            if (x < Enemies.Count)
            {
                Enemies[x].TakeDamageEnemy(character.Attack());
            }
            else { }

        }



        public async void CombatMode(Character personaje, Form2 form)  
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


            double totalEnemyLife = 0;

            for (int y = 0; y < Enemies.Count; y++)
            {
                totalEnemyLife = Enemies[y].Showlife() + totalEnemyLife;                    //define el limite de las curaciones diviendo la suma total de la vida de enemigos
                                                                                            //entre la vida del personaje y redondea a int
            }

            healLimit = (int)Math.Ceiling(totalEnemyLife / personaje.ShowCharacterLife());

            
            


            for (double i = personaje.ShowCharacterLife(); i > 0;)
            {
                

                buttonActionClick = new TaskCompletionSource<bool>();

                form.heroInfo.Text = "";
                form.EnemyInfo1.Text = "";
                form.EnemyInfo2.Text = "";
                form.EnemyInfo3.Text = "";
                form.EnemyInfo4.Text = "";                                                      //reinica los cuadros de texto
                form.EnemyInfo5.Text = "";
                form.buttonHeal.Text = "heal" +"(" + healLimit + ")";   


                form.heroInfo.Text = personaje.name + " | vida = " + personaje.ShowCharacterLife();             //imprime la informacion del personaje


                for (int j = 0; j < Enemies.Count; j++)
                {

                    if (Enemies[j].Showlife() > 0)      //verifica que el enemigo este vivo
                    {

                        if (Enemies[j].GetType().Name == "Goblin") { goblinImage[j].Visible = true; }       //si el enemigo es goblin, muestra la imagen de goblin           
                        else
                        {
                            vampireImage[j].Visible = true;                                                     // de otra forma es vampiro
                        }


                        enemyInfoText[j].Text = ("enemigo " + j + " " + Enemies[j].GetType().Name + " || vida = " + Enemies[j].Showlife());     //imprime la informacion del enemigo
                    }
                    else
                    {                

                        enemyInfoText[j].Text = " ha muerto";               //de otra forma el enemigo murio entonces se le da experiencia al personaje y se muestra el enemigo muerto
                    }
                }

                // turno del personaje
                
                form.buttonAttack.Enabled = true;

                if(healLimit > 0) {  form.buttonHeal.Enabled = true;}
                

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



                if (win <= 0)
                {
                    break;
                }
                if(personaje.ShowCharacterLife() <= 0)              // verificar condiciones de combate
                {
                    break;
                }
                else { }

            }

            if(personaje.ShowCharacterLife() <= 0)
            {
                form.heroInfo.Text = "";
                form.heroInfo.Text = ("game over");
            }
            else
            {
                Form3 form3 = new Form3(this, personaje);

                form3.Show();

                form.Hide();
            }
            


        }

        public async void reward(Character personaje, Form3 form)
        {

            buttonActionClick = new TaskCompletionSource<bool>();

            long reward = random.NextInt64(1, 6);

            if (reward == 1)
            {
                form.textBoxReward.Text = ("ganaste un macehete");
                await buttonActionClick.Task;             
            }
            
            if(reward == 2)
            {
                form.textBoxReward.Text = ("ganaste un claymore");
                await buttonActionClick.Task;

            }
            if (reward == 3)
            {
                form.textBoxReward.Text = ("ganaste un armadura de cuero");
                await buttonActionClick.Task;

            }
            if (reward == 4)
            {
                form.textBoxReward.Text = ("ganaste un armadura de hierro");
                await buttonActionClick.Task;

            }
            else
            {
                form.textBoxReward.Text = ("");
                form.buttonPlayAgain.Enabled = true;
                await buttonActionClick.Task;
            }
            
        }

    }

}