namespace Szachy.Atrybuty
{
    /// <summary>
    /// The pozycja.
    /// </summary>
    public class Pozycja
    {
        /// <summary>
        /// x.
        /// </summary>
        private int x;

        /// <summary>
        /// y.
        /// </summary>
        private int y;

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pozycja"/> class.
        /// </summary>
        /// <param name="x">
        /// x.
        /// </param>
        /// <param name="y">
        /// y.
        /// </param>
        public Pozycja(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}