using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // get number of enemies from user
            Console.Write("Enter number of enemies: ");
            int enemyNumber = int.Parse(Console.ReadLine());

            // init array of enemies
            Enemy[] enemies = new Enemy[enemyNumber];

            // create x enemies with name given by user
            for (int i = 0; i < enemyNumber; i++)
            {
                Console.Write($"Enter name for enemy {i + 1}: ");
                string name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }
        }
    }
}
