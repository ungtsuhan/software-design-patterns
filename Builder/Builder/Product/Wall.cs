using System;

namespace Builder.Product
{
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