using Abstract_Factory.AbstractProduct;

namespace Abstract_Factory.ConcreteFactory
{
    /// <summary>
    /// subclass of Room
    /// keep track of whether the room has a bomb in it and whether the bomb has gone off
    /// </summary>
    class RoomWithABomb : Room
    {
        public RoomWithABomb(int roomNumber) : base(roomNumber)
        {

        }
    }
}
