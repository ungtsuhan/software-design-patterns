using Abstract_Factory.Enum;
using System;

namespace Abstract_Factory.AbstractProduct
{
    /// <summary>
    /// Room is the concrete subclass of MapSite that defines the key relationships between components in the maze.
    /// It maintains references to other MapSite objects and stores a room number.
    /// The number will identify rooms in the maze.
    /// Each room has four sides. 
    /// </summary>
    class Room: MapSite
    {
        private readonly MapSite[] _sides = new MapSite[4];
        private readonly int _roomNumber;

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
        }

        /// <summary>
        /// operation to specify their sides
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="site"></param>
        public void SetSide(Direction dir, MapSite site)
        {
            Console.WriteLine($"Set {(Direction)dir} of room {_roomNumber} with a {site.GetType().Name}");
            _sides[(int)dir - 1] = site;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public MapSite GetSide(Direction dir)
        {
            return _sides[(int)dir - 1];
        }

        /// <summary>
        /// get room number of the room instance
        /// </summary>
        /// <returns></returns>
        public int GetRoomNumber()
        {
            return _roomNumber;
        }

        /// <summary>
        /// If you enter a room, your location changes
        /// </summary>
        public override void Enter()
        {
            Console.WriteLine("Entered a room successfully.");
        }
    }
}
