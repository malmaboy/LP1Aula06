using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy("Thor");
           // Console.WriteLine(Enemy.health); nao da para fazer print pk as variaveis são private
            Console.WriteLine(enemy.GetName());
        }   


    }
}
