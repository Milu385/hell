using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace entregable1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameEngine gameEngine = new GameEngine();
            gameEngine.ProcessGame();

            Console.WriteLine("Gracias por jugar!");
            
        }
    }
}
