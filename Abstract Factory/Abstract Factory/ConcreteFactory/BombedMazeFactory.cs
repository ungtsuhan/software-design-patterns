using Abstract_Factory.AbstractFactory;
using Abstract_Factory.AbstractProduct;
using System;

namespace Abstract_Factory.ConcreteFactory
{
    /// <summary>
    /// BombedMazeFactory subclassing MazeFactory
    /// override different member functions and return different subclasses of Room, Wall, etc
    /// </summary>
    class BombedMazeFactory : MazeFactory
    {
        /// <summary>
        /// make a room with a bomb (concrete product of Room) by specifying room number
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public override Room MakeRoom(int roomNumber)
        {
            Console.WriteLine($"Make a room with a bomb. room number : {roomNumber}");
            return new RoomWithABomb(roomNumber);
        }

        /// <summary>
        /// make a bombed wall (concrete product of Wall)
        /// </summary>
        /// <returns></returns>
        public override Wall MakeWall()
        {
            Console.WriteLine("Make a bombed wall");
            return new BombedWall();
        }
    }
}