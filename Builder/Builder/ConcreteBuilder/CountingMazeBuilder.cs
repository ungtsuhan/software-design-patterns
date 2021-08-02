using Builder.Builder;
using Builder.Enum;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    class CountingMazeBuilder: MazeBuilder
    {
        private Maze _currentMaze;
        private int _doors;
        private int _rooms;

        public CountingMazeBuilder()
        {
            _rooms = 0;
            _doors = 0;
        }

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = _rooms;
            doors = _doors;
        }

        public override void BuildRoom(int room)
        {
            _rooms++;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            _doors++;
        }

        public void AddWall(int n, Direction dir)
        {

        }

        /// <summary>
        /// Return the maze to the client.
        /// Override this operation to return the maze that they build.
        /// </summary>
        /// <returns></returns>
        public override Maze GetMaze()
        {
            return _currentMaze;
        }
    }
}
