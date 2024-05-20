using entregable1;

namespace hell
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {

           Character character = new Character(textBoxName.Text);

            Form2 form2 = new Form2(character);

            // Show Form2
            form2.Show();

            // Hide Form1 (optional)
            this.Hide();

        }

    }

}
