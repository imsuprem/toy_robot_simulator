namespace ToyRobotSimulator.Commands
{
    /// <summary>
    /// The concrete report command
    /// </summary>
    /// <seealso cref="ToyRobotSimulator.Commands.Command" />
    public class ReportCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCommand"/> class.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="table">The table.</param>
        public ReportCommand(Robot robot, Table table)
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
            return this.robot.Report;
        }
    }
}
