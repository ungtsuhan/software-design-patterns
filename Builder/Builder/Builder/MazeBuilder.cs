using Builder.Product;

namespace Builder.Builder
{
    /// <summary>
    /// This interface can create three things:
    /// (1) the maze
    /// (2) room with a particular room number
    /// (3) doors between numbered rooms.
    /// MazeBuilder does not create mazes itself; its main purpose is just to define an interface for creating mazes
    /// </summary>
    class MazeBuilder
    {
        protected MazeBuilder()
        {

        }

        public virtual void BuildMaze()
        {

        }

        public virtual void BuildRoom(int room)
        {

        }

        public virtual void BuildDoor(int roomFrom, int roomTo)
        {

        }

        /// <summary>
        /// Return the maze to the client.
        /// Subclasses of MazeBuilder will override this operation to return the maze that they build.
        /// </summary>
        /// <returns></returns>
        public virtual Maze GetMaze()
        {
            return new Maze();
        }
    }
}
