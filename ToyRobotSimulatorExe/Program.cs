namespace ToyRobotSimulatorExe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToyRobotSimulator;

    /// <summary>
    /// Executable for toy robot simulator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Simulator");
            var table = new Table(5, 5);
            var robot = new Robot();
            var commander = new Commander(robot, table);
            string input;

            while (!(input = Console.ReadLine()).Equals("EXIT"))
            {
                var command = commander.GetCommand(input);

                var output = command?.Execute();
                if (!string.IsNullOrEmpty(output))
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}
