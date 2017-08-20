namespace ToyRobotSimulator.Commands
{
    /// <summary>
    /// The concrete Move command
    /// </summary>
    /// <seealso cref="ToyRobotSimulator.Commands.Command" />
    public class MoveCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveCommand"/> class.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="table">The table.</param>
        public MoveCommand(Robot robot, Table table)
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

            var newPossition = this.robot.CurrentPosition.MoveOneUnit();
            if (this.table.IsValidPosition(newPossition))
            {
                this.robot.CurrentPosition = newPossition;
            }

            return string.Empty;
        }
    }
}
