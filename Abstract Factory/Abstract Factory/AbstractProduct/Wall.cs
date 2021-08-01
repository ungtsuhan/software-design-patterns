using System;

namespace Abstract_Factory.AbstractProduct
{
    /// <summary>
    /// Wall is subclass
    /// </summary>
    class Wall : MapSite
    {
        /// <summary>
        /// Wall cannot enter
        /// </summary>
        public override void Enter()
        {
            Console.WriteLine("Ouch! Ran into a wall.");
        }
    }
}
