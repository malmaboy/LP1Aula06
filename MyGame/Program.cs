using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis 
            int numEnimies;
            Enemy[] enemies;

            // Pedir ao utilizador nº de inimgos
            Console.WriteLine("Insira o nº de inimigos: ");
            numEnimies = Convert.ToInt32(Console.ReadLine());

            // Para cada inimigo pedir ao utilizador o seu nome,
            // criar objeto inimigos e guarda-lo num array

            enemies = new Enemy[numEnimies];

            for( int i = 0; i < numEnimies; i++)
            {
                string name;
                Console.WriteLine($"Insira o nome do inimigo #{i}:  ");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name); // Guardar num array
            }

            // Para cada inimigo, imprimir o seu nome

            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($">>{enemy.GetName()}<<");
            }

        }   


    }
}
