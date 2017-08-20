namespace ToyRobotSimulator
{
    using System;
    using ToyRobotSimulator.Commands;

    /// <summary>
    /// The Commander class. It's purpose is to construct and return the correct command object depending upon the command string passed 
    /// </summary>
    public class Commander
    {
        /// <summary>
        /// The robot
        /// </summary>
        private readonly Robot robot;

        /// <summary>
        /// The table
        /// </summary>
        private readonly Table table;

        /// <summary>
        /// Initializes a new instance of the <see cref="Commander"/> class.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="table">The table.</param>
        public Commander(Robot robot, Table table)
        {
            this.robot = robot;
            this.table = table;
        }

        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>returns the proper command object depending upon the command string passed</returns>
        public Command GetCommand(string command)
        {
            var commands = command.Split(new [] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (commands.Length < 1)
            {
                return null;
            }

            // Parse the command. IF the direction command is not exact match  to EAST, WEST, NORTH, SOUTH return null
            switch (commands[0])
            {
                case "PLACE":
                    {
                        try
                        {
                            var direction = (Directions)Enum.Parse(typeof(Directions), commands[3]);
                            return new PlaceCommand(
                                this.robot,
                                this.table,
                                new Position(int.Parse(commands[1]), int.Parse(commands[2]), direction));
                        }
                        catch (ArgumentException)
                        {
                            return null;
                        }
                        catch (OverflowException)
                        {
                            return null;
                        }
                    }

                case "MOVE":
                    {
                        return new MoveCommand(this.robot, this.table);
                    }
                case "RIGHT":
                    {
                        return  new RightCommand(this.robot, this.table);
                    }
                case "REPORT":
                    {
                        return  new ReportCommand(this.robot, this.table);
                    }

                case "LEFT":
                    {
                        return new LeftCommand(this.robot, this.table);
                    }

                default: return null;
            }
        }
    }
}
