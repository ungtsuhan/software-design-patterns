using System;
using System.Collections.Generic;

namespace Builder.Product
{
    class Maze
    {
        private readonly Dictionary<int, Room> _rooms = new();
        private Room _currentRoom;

        /// <summary>
        /// Add room into the maze
        /// </summary>
        /// <param name="r"></param>
        public void AddRoom(Room r)
        {
            Console.WriteLine($"Add room {r.GetRoomNumber()} to maze");
            _rooms.Add(r.GetRoomNumber(), r);
        }

        /// <summary>
        /// Get particular room instance in this maze by specifying room number
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public Room GetRoom(int roomNumber)
        {
            return _rooms.GetValueOrDefault(roomNumber);
        }

        /// <summary>
        /// Get number of room instance in the maze
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfRooms()
        {
            return _rooms.Count;
        }

        /// <summary>
        /// Get current room in the maze
        /// </summary>
        /// <returns></returns>
        public Room GetCurrentRoom()
        {
            return _currentRoom;
        }

        /// <summary>
        /// Set current room by specifying room instance
        /// </summary>
        /// <returns></returns>
        public void SetCurrentRoom(Room room)
        {
            _currentRoom = room;
        }

        /// <summary>
        /// Set current room by specifying room number
        /// </summary>
        /// <param name="roomNumber"></param>
        public void SetCurrentRoom(int roomNumber)
        {
            _currentRoom = _rooms.GetValueOrDefault(roomNumber);
        }
    }
}