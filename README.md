# CSharpToyRobot
Coding Challenge for the Toy Robot in C#
# Description

•	The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.

•	There are no other obstructions on the table surface.

•	The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in the robot falling from the table must be prevented, however further valid movement commands must still be allowed.
## Create an application that can read in commands of the following form:

MOVE
LEFT
RIGHT
REPORT

•	The origin (0,0) can be considered to be the SOUTH WEST most corner.  
•	The first valid command to the robot is a PLACE command, after that, any sequence of commands may be issued, in any order, including another PLACE command. The application should discard all commands in the sequence until a valid PLACE command has been executed.  
•	MOVE will move the toy robot one unit forward in the direction it is currently facing.  
•	LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.  
•	REPORT will announce the X,Y and F of the robot. This can be in any form, but standard output is sufficient.  
•	A robot that is not on the table can choose the ignore the MOVE, LEFT, RIGHT and REPORT commands.  
•	Input can be from a file, or from standard input, as the developer chooses.  
•	Provide test data to exercise the application.

## Constraints

•	The toy robot must not fall off the table during movement. This also includes the initial placement of the toy robot.  
•	Any move that would cause the robot to fall must be ignored.

## Example Input and Output

### Example a 
MOVE  
Expected output:  
0,1,NORTH

### Example b 
LEFT  
REPORT  
Expected output:  
0,0,WEST  

### Example c
MOVE  
MOVE  
LEFT  
MOVE  
REPORT  
Expected output  
3,3,NORTH  

# Next Steps
This Toy Robot is a constantly growing project as I learn my way through C#...

Firstly:So the initial challenge asks for the user to place there 🤖 on X/Y coordinates, that is something I haven't implement as of yet but that is the first step.

Secondly: I haven't spent any time learning how to Test in C# yat, that is also next on the list of things to complete.
