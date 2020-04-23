using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy("Thor");
           // Console.WriteLine(Enemy.health); nao da para fazer print pk as variaveis são private
            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth}");
            
            loki.SetName($"Name is >>");

        }


        static void Ex2()
        {
            // Declaração de variaveis

            int numEnemies;
            Enemy[] enemies; 

            // Pedir ao utilizador nº de inimigos 
            Console.WriteLine("Insira nº de inimigos :");
            numEnemies = Convert.ToInt(Console.ReadLine());


            // Para cada inimigo pedir ao utilizador o seu nome
            // criar objeto inimigo e guarda-lo num array
            enemies = new Enemy[numEnemies];

            for ( int i = 0; i < numEnemies; i++)
            {
                string name;
                Console.WriteLine($"Insira o nome do inimigo #{i}: ");
                name = Console.ReadLine();
                enimies[i] = new Enemy(name);
            }




            // para cada inimigo imprimir o seu nome

            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($">>{enemy.GetName()}<<");
            }
        }
    }
}
