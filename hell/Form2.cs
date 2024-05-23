using entregable1;

namespace hell
{
    public partial class Form2 : Form
    {

        Combatsystem combatsystem;

        Character character;

        public TaskCompletionSource<bool> buttonAttackClick;

        public Form2(Combatsystem combatsystem, Character character)
        {
            InitializeComponent();
            this.combatsystem = combatsystem;
            this.character = character;
        }

        private async void buttonAttack_Click(object sender, EventArgs e)
        {

            buttonAttackClick = new TaskCompletionSource<bool>();

            labelTarget.Visible = true;

            buttonConfirmAttack.Visible = true;
            buttonConfirmAttack.Enabled = true;

            textboxTarget.Visible = true;
            textboxTarget.Enabled = true;


            await buttonAttackClick.Task;



        }

        private void buttonConfirmAttack_Click(object sender, EventArgs e)
        {

            combatsystem.DamageEnemy(character, int.Parse(textboxTarget.Text));

            labelTarget.Visible = false;

            buttonConfirmAttack.Visible = false;
            buttonConfirmAttack.Enabled = false;

            textboxTarget.Visible = false;
            textboxTarget.Enabled = false;

            buttonAttackClick.TrySetResult(true);

            combatsystem.buttonActionClick.TrySetResult(true);

        }

        private void buttonHeal_Click(object sender, EventArgs e)
        {

            character.Heal();
            combatsystem.healLimit--;
            combatsystem.buttonActionClick.TrySetResult(true);
        }
    }
}
