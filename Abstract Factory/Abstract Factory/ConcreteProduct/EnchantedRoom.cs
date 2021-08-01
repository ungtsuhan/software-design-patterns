using Abstract_Factory.AbstractProduct;

namespace Abstract_Factory
{
    /// <summary>
    /// subclass of Room
    /// </summary>
    class EnchantedRoom : Room
    {
        private readonly int _roomNumber;
        private readonly Spell _spell;

        public EnchantedRoom(int roomNumber, Spell spell) : base(roomNumber)
        {
            _roomNumber = roomNumber;
            _spell = spell;
        }
    }
}
