using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis 
            int numEnemies;
            Enemy[] enemies;
            Random random = new Random();

            // Pedir ao utilizador nº de inimgos
            Console.WriteLine("Insira o nº de inimigos: ");
            numEnemies = Convert.ToInt32(Console.ReadLine());

            // Para cada inimigo pedir ao utilizador o seu nome,
            // criar objeto inimigos e guarda-lo num array

            enemies = new Enemy[numEnemies];

            for( int i = 0; i < numEnemies; i++)
            {
                string name;
                Console.WriteLine($"Insira o nome do inimigo #{i}:  ");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name); // Guardar num array

                if(random.NextDouble() < 0.5)
                {
                    enemies[i].PickupPowerUp(PowerUp.Shield, 50 );
                }
                else
                {
                    enemies[i].TakeDamage(100);
                }
            }

            // Para cada inimigo, imprimir o seu nome

            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine
                ($">>{enemy.GetName()}<< >>HP= {enemy.GetHealth()}<< >>{enemy.GetShield()}<<");
            }


            Console.WriteLine($"Poweup count: {Enemy.GetPowerupCount()}");
        }   


    }
}
