using Abstract_Factory.AbstractProduct;
using System;

namespace Abstract_Factory.AbstractFactory
{
    /// <summary>
    /// MazeFactory can create components of mazes.
    /// It builds rooms, walls, and doors between rooms.
    /// </summary>
    class MazeFactory
    {
        /// <summary>
        /// make a maze (product)
        /// </summary>
        /// <returns></returns>
        public virtual Maze MakeMaze()
        {
            Console.WriteLine("Make a maze");
            return new Maze();
        }

        /// <summary>
        /// make a room (product) by specifying room number
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public virtual Room MakeRoom(int roomNumber)
        {
            Console.WriteLine($"Make a room. room number : {roomNumber}");
            return new Room(roomNumber);
        }

        /// <summary>
        /// make a wall (product)
        /// </summary>
        /// <returns></returns>
        public virtual Wall MakeWall()
        {
            Console.WriteLine("Make a wall");
            return new Wall();
        }

        /// <summary>
        /// make a door (product) by specifying room 1 and room 2 which connected by the door
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public virtual Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine($"Make a door which connects room {r1.GetRoomNumber()} and room {r2.GetRoomNumber()}");
            return new Door(r1, r2);
        }
    }
}
