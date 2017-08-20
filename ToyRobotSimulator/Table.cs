namespace ToyRobotSimulator
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The table class
    /// </summary>
    public class Table
    {
        /// <summary>
        /// The length
        /// </summary>
        private readonly uint length;

        /// <summary>
        /// The width
        /// </summary>
        private readonly uint width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        public Table(uint length, uint width)
        {
            this.length = length;
            this.width = width;
        }

        /// <summary>
        /// Determines whether the position object passed in as a parameter is valid in the context of the table
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>
        ///   <c>true</c> if [is valid position] [the specified position]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidPosition(Position position)
        {
            return position.X >= 0 && position.Y >= 0 && position.X <= this.length && position.Y <= this.width;
        }
    }
}
