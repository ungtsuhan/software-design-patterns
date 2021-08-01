using Abstract_Factory.AbstractProduct;

namespace Abstract_Factory
{
    /// <summary>
    /// subclass of Door
    /// </summary>
    class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room r1, Room r2) : base(r1, r2)
        {

        }
    }
}
