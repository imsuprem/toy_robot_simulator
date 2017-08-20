namespace ToyRobot.Specs
{
    using ToyRobotSimulator;
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    using Table = TechTalk.SpecFlow.Table;

    [Binding]
    public class RobotSimulatorSteps
    {
        private ToyRobotSimulator.Table table;

        private Robot robot;

        private Commander commander;

        private string report;

        [Given(@"I have Initialised the Robot")]
        public void GivenIHaveInitialisedTheRobot()
        {
            this.table = new ToyRobotSimulator.Table(5, 5);
            this.robot = new Robot();
            this.commander = new Commander(this.robot, this.table);
        }
        
        [Given(@"I have not issued any PLACE command yet")]
        public void GivenIHaveNotIssuedAnyPLACECommandYet()
        {
            this.robot.CurrentPosition = null;
        }
        
        [When(@"I issue a REPORT command to the Robot")]
        public void WhenIIssueAREPORTCommandToTheRobot()
        {
            this.report = this.robot.Report;
        }
        
        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShould(string p0)
        {
            Assert.AreEqual(this.report, p0);
        }

        [When(@"I issue following commands to the robot")]
        public void WhenIIssueFollowingCommandsToTheRobot(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                var command = this.commander.GetCommand(tableRow["Commands"]);
                command?.Execute();
            }
        }

        [When(@"I issue a MOVE command to the robot")]
        public void WhenIIssueAMOVECommandToTheRobot()
        {
            var command = this.commander.GetCommand("MOVE");
            command?.Execute();
        }

        [Given(@"I have placed the robot at origin facing EAST")]
        public void GivenIHavePlacedTheRobotAtOriginFacingEAST()
        {
            var command = this.commander.GetCommand("PLACE 0,0,EAST");
            command?.Execute();
        }

        [Given(@"I have placed the robot at origin facing WEST")]
        public void GivenIHavePlacedTheRobotAtOriginFacingWEST()
        {
            var command = this.commander.GetCommand("PLACE 0,0,WEST");
            command?.Execute();
        }

        [When(@"I issue a LEFT command to the robot")]
        public void WhenIIssueALEFTCommandToTheRobot()
        {
            var command = this.commander.GetCommand("LEFT");
            command?.Execute();
        }

        [When(@"I issue a RIGHT command to the robot")]
        public void WhenIIssueARIGHTCommandToTheRobot()
        {
            var command = this.commander.GetCommand("RIGHT");
            command?.Execute();
        }
    }
}
