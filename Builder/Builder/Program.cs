using Builder.ConcreteBuilder;
using Builder.Director;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int rooms, doors;
            MazeGame game = new MazeGame();
            CountingMazeBuilder builder = new CountingMazeBuilder();

            game.CreateMaze(builder);
            builder.GetCounts(out rooms, out doors);
            Console.WriteLine($"The maze has {rooms} rooms and {doors} doors");

            Console.ReadLine();
        }
    }
}
