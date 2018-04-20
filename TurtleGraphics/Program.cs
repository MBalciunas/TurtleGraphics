using System;

namespace TurtleGraphics
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameLoop();

            Console.WriteLine("\nThanks for playing, goodbye!");
        }
    }
}
