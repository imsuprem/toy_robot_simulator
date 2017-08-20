namespace ToyRobotSimulator.Commands
{
    /// <summary>
    /// The base class for creating all commands. 
    /// It's execute method must me overridden by the concrete command like MoveCommand or ReportCommand etc. to implement their own behavior.
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// The robot
        /// </summary>
        protected Robot robot;

        /// <summary>
        /// The table
        /// </summary>
        protected Table table;

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="table">The table.</param>
        protected Command(Robot robot, Table table)
        {
            this.robot = robot;
            this.table = table;
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <returns> Executes the command and returns a string result.</returns>
        public abstract string Execute();
    }
}
