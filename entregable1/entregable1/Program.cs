using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace entregable1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            

            int number;

            Console.WriteLine("eliga un nombre para su personaje");

            string nombre = Console.ReadLine();

            Character character = new Character(nombre);

            character.levelUp += (sender, e) =>
            {
                Console.WriteLine(character.name + "ha subido de nivel");

                character.xpCap = character.xpCap * 2;
            };


            do
            {

                Combatsystem combate = new Combatsystem();

                combate.CombatMode(character);

                combate.reward(character);

                Console.WriteLine("desea seguir jugando? \n 1. si \n 2.no");

                string input = Console.ReadLine();

                Int32.TryParse(input, out number);


            } while (number == 1);













        }
    }
}
