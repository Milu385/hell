using entregable1;

namespace hell
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Combatsystem combatsystem = new Combatsystem();


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}