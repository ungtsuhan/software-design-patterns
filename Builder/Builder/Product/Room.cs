using Builder.Enum;
using System;

namespace Builder.Product
{
    class Room
    {
        private readonly MapSite[] _sides = new MapSite[4];
        private readonly int _roomNumber;

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
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
    }
}
