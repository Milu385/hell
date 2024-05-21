using entregable1;

namespace hell
{
    public partial class Form2 : Form
    {

        Combatsystem combatsystem;

        public Form2(Combatsystem combatsystem)
        {
            InitializeComponent();
            this.combatsystem = combatsystem;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            combatsystem.buttonActionClick.TrySetResult(true);
                      
        }
    }
}
