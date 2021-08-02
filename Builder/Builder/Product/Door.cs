using Builder.Product;
using System;

namespace Builder.ConcreteBuilder
{
    class Door : MapSite
    {
        private readonly Room _r1;
        private readonly Room _r2;
        private bool _isOpen;

        public Door(Room r1, Room r2)
        {
            _r1 = r1;
            _r2 = r2;
            _isOpen = true;
        }

        /// <summary>
        /// If door is open, you go into next room
        /// If door is closed, your hurt your nose
        /// </summary>
        public override void Enter()
        {
            if (_isOpen)
                Console.WriteLine("Enter next room successfully!");
            else
                Console.WriteLine("Door is closed. You hurt your nose!");
        }

        /// <summary>
        /// Get Room 1 which connected by this door
        /// </summary>
        /// <returns></returns>
        public Room GetRoom1()
        {
            return _r1;
        }

        /// <summary>
        /// Get Room 2 which connected by this door
        /// </summary>
        /// <returns></returns>
        public Room GetRoom2()
        {
            return _r2;
        }

        /// <summary>
        /// Set door to either open or closed
        /// </summary>
        /// <param name="open"></param>
        public void SetOpen(bool open)
        {
            _isOpen = open;
        }
    }
}