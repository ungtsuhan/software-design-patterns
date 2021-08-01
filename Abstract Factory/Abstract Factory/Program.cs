using Abstract_Factory.AbstractFactory;
using Abstract_Factory.ConcreteFactory;
using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------");
                Console.WriteLine("1  :  Bombed Maze");
                Console.WriteLine("2  :  Enchanted Maze");
                Console.WriteLine("--------------------");
                Console.Write("Select Maze Type: ");

                MazeGame game = new MazeGame();

                switch (Console.ReadLine())
                {
                    // To build a maze that can contain bombs
                    case "1":
                        MazeFactory bfactory = new BombedMazeFactory();
                        game.CreateMaze(bfactory);
                        break;

                    // To build an enchanted maze
                    case "2":
                        MazeFactory efactory = new EnchantedMazeFactory();
                        game.CreateMaze(efactory);
                        break;

                    default:
                        break;
                }

                Console.Write("\nDo you want to create a new maze? y/n: ");
            }
            while (Console.ReadLine() == "y"); 
        }
    }
}
