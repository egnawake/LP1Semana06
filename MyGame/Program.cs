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

            // print each enemy's name
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()}");
            }

            enemies[0].TakeDamage(15);
            Console.WriteLine("{0} took damage! HP: {1} | Shield: {2}",
                enemies[0].GetName(),
                enemies[0].GetHealth(),
                enemies[0].GetShield()
            );

            enemies[0].PickupPowerUp(PowerUp.Shield, 20);
            Console.WriteLine("{0} got a shield boost! HP: {1} | Shield: {2}",
                enemies[0].GetName(),
                enemies[0].GetHealth(),
                enemies[0].GetShield()
            );

            enemies[0].PickupPowerUp(PowerUp.Shield, 15);
            enemies[0].PickupPowerUp(PowerUp.Health, 10);

            Console.WriteLine($"Total collected powerups: {Enemy.GetTotalCollectedPowerups()}");

            Console.WriteLine("Merci d’utiliser ce programme!");
        }
    }
}
