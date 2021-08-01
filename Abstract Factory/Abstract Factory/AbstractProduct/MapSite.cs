namespace Abstract_Factory.AbstractProduct
{
    /// <summary>
    /// MapSite is the common abstract class for all the components of a maze
    /// </summary>
    public abstract class MapSite
    {
        /// <summary>
        /// Its meaning depends on what you're entering (Room / Door / Wall).
        /// </summary>
        public abstract void Enter();
    }
}
