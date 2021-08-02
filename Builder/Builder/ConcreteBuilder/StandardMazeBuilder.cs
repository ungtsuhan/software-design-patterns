using Builder.Builder;
using Builder.Enum;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    class StandardMazeBuilder: MazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder()
        {

        }

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override void BuildRoom(int roomNumber)
        {
            if(_currentMaze.GetRoom(roomNumber) != null)
            {
                Room room = new Room(roomNumber);
                _currentMaze.AddRoom(room);

                room.SetSide(Direction.NORTH, new Wall());
                room.SetSide(Direction.SOUTH, new Wall());
                room.SetSide(Direction.EAST, new Wall());
                room.SetSide(Direction.WEST, new Wall());
            }
        }

        /// <summary>
        /// To build a door between two rooms, StandardMazeBuilder looks up both rooms in the maze and finds their adjoining wall 
        /// </summary>
        /// <param name="roomFrom"></param>
        /// <param name="roomTo"></param>
        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = _currentMaze.GetRoom(roomFrom);
            Room r2 = _currentMaze.GetRoom(roomTo);
            Door d = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), d);
            r2.SetSide(CommonWall(r2, r1), d);
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

        /// <summary>
        /// Utility operation that determines the direction of the common wall between two rooms.
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        private Direction CommonWall(Room r1, Room r2)
        {
            // TODO check this algorithm
            // reference: 
            if (r1.GetRoomNumber() > r2.GetRoomNumber())
                return Direction.EAST;
            else
                return Direction.WEST;
        }
    }
}
