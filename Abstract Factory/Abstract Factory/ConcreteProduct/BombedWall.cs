using Abstract_Factory.AbstractProduct;

namespace Abstract_Factory
{
    /// <summary>
    /// subclass of Wall
    /// keep track of the damage done to the wall
    /// </summary>
    class BombedWall : Wall
    {
        private readonly bool _bomb;

        public BombedWall()
        {
            _bomb = false;
        }

        public BombedWall(bool hasBomb)
        {
            _bomb = hasBomb;
        }

        /// <summary>
        /// get whether the wall has bombed
        /// </summary>
        /// <returns></returns>
        public bool HasBomb()
        {
            return _bomb;
        }
    }
}
