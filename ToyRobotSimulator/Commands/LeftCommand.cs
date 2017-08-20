namespace ToyRobotSimulator.Commands
{
    /// <summary>
    /// Concrete left command
    /// </summary>
    /// <seealso cref="ToyRobotSimulator.Commands.Command" />
    public class LeftCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeftCommand"/> class.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="table">The table.</param>
        public LeftCommand(Robot robot, Table table)
            : base(robot, table)
        {
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <returns>
        /// Executes the command and returns a string result.
        /// </returns>
        public override string Execute()
        {
            if (!this.robot.IsPlaced)
            {
                return string.Empty;
            }

            var newPossition = this.robot.CurrentPosition.TurnLeft();
            if (this.table.IsValidPosition(newPossition))
            {
                this.robot.CurrentPosition = newPossition;
            }

            return string.Empty;
        }
    }
}
