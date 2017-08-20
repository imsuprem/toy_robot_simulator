namespace ToyRobotSimulator.Commands
{
    /// <summary>
    /// The concrete place command
    /// </summary>
    /// <seealso cref="ToyRobotSimulator.Commands.Command" />
    public class PlaceCommand : Command
    {
        /// <summary>
        /// The position
        /// </summary>
        private readonly Position position;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceCommand"/> class.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="table">The table.</param>
        /// <param name="position">The position.</param>
        public PlaceCommand(Robot robot, Table table, Position position)
            : base(robot, table)
        {
            this.position = position;
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <returns>
        /// Executes the command and returns a string result.
        /// </returns>
        public override string Execute()
        {
            if (this.table.IsValidPosition(this.position))
            {
                this.robot.CurrentPosition = this.position;
            }
            
            return string.Empty;
        }
    }
}
