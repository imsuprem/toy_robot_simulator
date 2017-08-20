Feature: Robot Simulator
	In order to Test the robot simulator
	As a command dispatcher
	I want to be able to dispatch commands to the Robot

@RobotSimulatorTag
Scenario: No PLACE command issued
	Given I have Initialised the Robot
	And I have not issued any PLACE command yet
	When I issue a REPORT command to the Robot
	Then the result should be 'Robot is not placed.'

Scenario: Invalid PLACE command issued

	Given I have Initialised the Robot

	When I issue following commands to the robot
	| Commands | 
	| PLACE -1,0,NORTH   |
	| PLACE 0,-1,NORTH   |
	| PLACE 0,-0,HIGH    |
	And I issue a REPORT command to the Robot
    Then the result should be 'Robot is not placed.'

	When I issue following commands to the robot
	| Commands | 
	| PLACE 1,0,NORTH   |
	| PLACE 0,-1,NORTH   |
	| PLACE 0,-0,HIGH    |
	And I issue a REPORT command to the Robot
    Then the result should be '1,0,NORTH'

	When I issue following commands to the robot
	| Commands | 
	| PLACE 1,0,NORTH   |
	| PLACE 0,-1,NORTH   |
	| PLACE 0,-0,EAST    |
	And I issue a REPORT command to the Robot
    Then the result should be '0,0,EAST'

Scenario: Valid PLACE command issued

	Given I have Initialised the Robot

	When I issue following commands to the robot
	| Commands | 
	| PLACE 1,0,NORTH   |
	And I issue a REPORT command to the Robot
    Then the result should be '1,0,NORTH'

	When I issue following commands to the robot
	| Commands | 
	| PLACE 5,5,EAST   |
	And I issue a REPORT command to the Robot
    Then the result should be '5,5,EAST'

	When I issue following commands to the robot
	| Commands | 
	| PLACE 5,0,EAST   |
	And I issue a REPORT command to the Robot
    Then the result should be '5,0,EAST'

Scenario: Valid MOVE command issued
	Given I have Initialised the Robot
	And I have placed the robot at origin facing EAST
	When I issue a MOVE command to the robot
	And I issue a REPORT command to the Robot
	Then the result should be '1,0,EAST'

Scenario: Invalid MOVE command issued
	Given I have Initialised the Robot
	And I have placed the robot at origin facing WEST
	When I issue a MOVE command to the robot
	And I issue a REPORT command to the Robot
	Then the result should be '0,0,WEST'

Scenario: LEFT command issued
	Given I have Initialised the Robot
	And I have placed the robot at origin facing WEST
	When I issue a LEFT command to the robot
	And I issue a REPORT command to the Robot
	Then the result should be '0,0,SOUTH'

Scenario: RIGHT command issued
	Given I have Initialised the Robot
	And I have placed the robot at origin facing WEST
	When I issue a RIGHT command to the robot
	And I issue a REPORT command to the Robot
	Then the result should be '0,0,NORTH'

Scenario: Test Command Batches

	Given I have Initialised the Robot

	When I issue following commands to the robot
	| Commands        |
	| PLACE 0,0,NORTH |
	| MOVE            | 
	| MOVE            | 
	| MOVE            | 
	| MOVE            | 
	| MOVE            | 
	| MOVE            | 
	And I issue a REPORT command to the Robot
    Then the result should be '0,5,NORTH'

	When I issue following commands to the robot
	| Commands        |
	| PLACE 0,0,NORTH |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| RIGHT           |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	And I issue a REPORT command to the Robot
    Then the result should be '5,5,EAST'

	When I issue following commands to the robot
	| Commands        |
	| PLACE 0,0,NORTH |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| RIGHT           |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| MOVE            |
	| RIGHT           |
	| MOVE            |
	And I issue a REPORT command to the Robot
    Then the result should be '5,4,SOUTH'