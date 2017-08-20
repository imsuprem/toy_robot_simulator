namespace ToyRobot.Specs
{
    using NUnit.Framework;

    using ToyRobotSimulator;

    using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

    /// <summary>
    /// Summary description for PlaceCommandTest
    /// </summary>
    [TestFixture]
    public class RobotSimulatorTests
    {
        /// <summary>
        /// The table
        /// </summary>
        private ToyRobotSimulator.Table table;

        /// <summary>
        /// The robot
        /// </summary>
        private Robot robot;

        /// <summary>
        /// The commander
        /// </summary>
        private Commander commander;

        /// <summary>
        /// The report
        /// </summary>
        private string report;

        /// <summary>
        /// The not placed result
        /// </summary>
        private string notPlacedResult = "Robot is not placed.";

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotSimulatorTests"/> class.
        /// </summary>
        public RobotSimulatorTests()
        {
            this.table = new Table(5, 5);
            this.robot = new Robot();
            this.commander = new Commander(this.robot, this.table);
        }
        
        /// <summary>
        /// Reports the when robot is not placed.
        /// </summary>
        [Test]
        public void ReportOutputWhenRobotIsNotPlaced()
        {
            this.report = this.robot.Report;
            Assert.AreEqual(this.notPlacedResult, this.report);
        }

        /// <summary>
        /// Reports the output when robot is placed at invalid position.
        /// </summary>
        [Test]
        public void ReportOutputWhenRobotIsPlacedAtInvalidPosition()
        {
            this.commander.GetCommand("PLACE -1, -1, INVALID");
            this.report = this.robot.Report;
            Assert.AreEqual(this.notPlacedResult, this.report);
        }
    }

}
