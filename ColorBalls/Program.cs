using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color(255,0,0);
            Color purple = new Color(255,0,255,127);


            Ball BigRed = new Ball(red, 5);
            Ball LittlePurple = new Ball (purple, 3);
            BigRed.Throw();
            BigRed.Throw();
            BigRed.Throw();


            Console.WriteLine($"Red throw {BigRed.GetNumberOfThows()} ");

            BigRed.Throw();
            BigRed.Throw();

            Console.WriteLine($"Red throw {BigRed.GetNumberOfThows()} ");

            LittlePurple.Throw();
            LittlePurple.Throw();

            Console.WriteLine($"Purple throw { LittlePurple .GetNumberOfThows()} ");

            LittlePurple.Pop();
            LittlePurple.Throw();

            Console.WriteLine($"Purple throw { LittlePurple .GetNumberOfThows()} ");




        }
    }
}
