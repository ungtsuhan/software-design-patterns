using Abstract_Factory.AbstractFactory;
using Abstract_Factory.AbstractProduct;
using Abstract_Factory.Enum;
using System;

namespace Abstract_Factory
{
    class MazeGame
    {
        /// <summary>
        /// function which creates a different type of maze by specifying the concrete maze factory instance
        /// </summary>
        /// <param name="factory"></param>
        /// <returns></returns>
        public Maze CreateMaze(MazeFactory factory)
        {
            Console.WriteLine();

            Maze aMaze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(1);
            Room r2 = factory.MakeRoom(2);
            Door aDoor = factory.MakeDoor(r1, r2);

            Console.WriteLine();

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            Console.WriteLine();

            r1.SetSide(Direction.NORTH, factory.MakeWall());
            r1.SetSide(Direction.EAST, aDoor);
            r1.SetSide(Direction.SOUTH, factory.MakeWall());
            r1.SetSide(Direction.WEST, factory.MakeWall());

            r2.SetSide(Direction.NORTH, factory.MakeWall());
            r2.SetSide(Direction.EAST, factory.MakeWall());
            r2.SetSide(Direction.SOUTH, factory.MakeWall());
            r2.SetSide(Direction.WEST, aDoor);

            Console.WriteLine("\nMaze is created successfully");

            aMaze.SetCurrentRoom(0);

            return aMaze;
        }
    }
}
