namespace ToyRobotSimulator
{
    /// <summary>
    /// The Position class. It requires x, y and direction to initialize.
    /// Three methods to turn left, turn right and Move one unit in the default direction (the direction robot is facing.) 
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="direction">The direction.</param>
        public Position(int x, int y, Directions direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        public int X { get; }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        public int Y { get; }

        /// <summary>
        /// Gets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public Directions Direction { get; }

        /// <summary>
        /// Moves the position object one unit in default direction
        /// </summary>
        /// <returns>returns the changed postion object after moving it in the direction</returns>
        public Position MoveOneUnit()
        {
            
            switch (this.Direction)
            {
                case Directions.NORTH:
                    return new Position(this.X, this.Y + 1, this.Direction);
                case Directions.SOUTH:
                    return new Position(this.X, this.Y - 1, this.Direction);
                case Directions.EAST:
                    return new Position(this.X + 1, this.Y, this.Direction);
                case Directions.WEST:
                    return new Position(this.X - 1, this.Y, this.Direction);
                default: return this;
                    
            }
        }

        /// <summary>
        /// Turns the left.
        /// </summary>
        /// <returns></returns>
        public Position TurnLeft()
        {
            var direction = (Directions)(((int)this.Direction - 1) % 4);
            return new Position(this.X, this.Y, direction);
        }

        /// <summary>
        /// Turns the right.
        /// </summary>
        /// <returns></returns>
        public Position TurnRight()
        {
            var direction = (Directions)(((int)this.Direction + 1) % 4);
            return new Position(this.X, this.Y, direction);
        }
    }
}
