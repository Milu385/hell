using entregable1;

namespace hell
{
    public partial class Form2 : Form
    {

        public Character hero;

        public Form2(Character character)
        {
            hero = character;

            Combatsystem combatsystem = new Combatsystem();

            InitializeComponent();

            

        }

    }
}
