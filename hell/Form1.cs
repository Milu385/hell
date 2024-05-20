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

            
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Hide Form1 (optional)
            this.Hide();

        }
    }
}
