using entregable1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hell
{
    public partial class Form3 : Form
    {

        Combatsystem combatsystem;
        Character character;


        public Form3(Combatsystem combatsystem, Character character)
        {
            InitializeComponent();
            this.combatsystem = combatsystem;
            this.character = character;
            combatsystem.reward(character, this);
        }

        private void buttonEquip_Click(object sender, EventArgs e)
        {
            if (textBoxReward.Text == ("ganaste un macehete"))
            {
                Machete machete = new Machete();
                character.Equip(machete);
                combatsystem.buttonActionClick.TrySetResult(true);
            }
            if (textBoxReward.Text == ("ganaste un claymore"))
            {
                Claymore claymore = new Claymore();
                character.Equip(claymore);
                combatsystem.buttonActionClick.TrySetResult(true);
            }
            if (textBoxReward.Text == ("ganaste un armadura de cuero"))
            {
                LeatherArmor leatherArmor = new LeatherArmor();
                character.Equip(leatherArmor);
                combatsystem.buttonActionClick.TrySetResult(true);
            }
            if (textBoxReward.Text == ("ganaste un armadura de hierro"))
            {
                PlateArmor plateArmor = new PlateArmor();
                character.Equip(plateArmor);
                combatsystem.buttonActionClick.TrySetResult(true);
            }
            else
            {
                
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            combatsystem.buttonActionClick.TrySetResult(true);
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {

            Combatsystem combatsystem = new Combatsystem();

            Form2 form2 = new Form2(combatsystem, character);
    
            form2.Show();
         
            this.Hide();

            combatsystem.CombatMode(character, form2);


        }
    }
}
