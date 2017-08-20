namespace ToyRobotSimulator
{
    /// <summary>
    /// The Robot Class. Initialized with CurrentPosition = null. Place command will be used to alter this Position. 
    /// Another method Report() will be used to report the current position
    /// </summary>
    public class Robot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class.
        /// </summary>
        public Robot()
        {
            this.CurrentPosition = null;
        }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        /// <value>
        /// The current position.
        /// </value>
        public Position CurrentPosition { get; set; }


        /// <summary>
        /// Gets the report.
        /// </summary>
        /// <value>
        /// The report.
        /// </value>
        public string Report
        {
            get
            {
                if (this.IsPlaced)
                {
                    return $"{this.CurrentPosition.X},{this.CurrentPosition.Y},{this.CurrentPosition.Direction}";
                }

                return "Robot is not placed.";
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is placed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is placed; otherwise, <c>false</c>.
        /// </value>
        public bool IsPlaced => this.CurrentPosition != null;
    }
}
