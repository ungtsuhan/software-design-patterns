using Abstract_Factory.AbstractFactory;
using Abstract_Factory.AbstractProduct;
using System;

namespace Abstract_Factory.ConcreteFactory
{
    /// <summary>
    /// EnchantedMazeFactory subclassing MazeFactory
    /// override different member functions and return different subclasses of Room, Wall, etc
    /// </summary>
    class EnchantedMazeFactory : MazeFactory
    {
        /// <summary>
        /// make a enchanted room (concrete product of Room) by specifying room number
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public override Room MakeRoom(int roomNumber)
        {
            Console.WriteLine($"Make an enchanted room. room number : {roomNumber}");
            return new EnchantedRoom(roomNumber, CastSpell());
        }

        /// <summary>
        /// make a door needing spell (concrete product of Door) by specifying room 1 and room 2 which connected by the door
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public override Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine($"Make a door needing spell which connect room {r1.GetRoomNumber()} and room {r2.GetRoomNumber()}");
            return new DoorNeedingSpell(r1, r2);
        }

        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}