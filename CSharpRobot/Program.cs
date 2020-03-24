using System;
using System.Collections.Generic;

namespace ToyRobot
{
    class Program
    {
        static bool inGame = true;
        static string input;
        static string direction = "north";
        // List instantiates a set list of the directions so I can increment/decrement through them as the user selects left/right
        static List<string> directions = new List<string>() { "north", "east", "south", "west" };
        static int locX = 0; // east/west
        static int locY = 0; // north/south
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Welcome to the robot challenge\nYou are a robot on a 5x5 table placed on the South West corner\nThe inputs to play the game are\nmove - Will move you one step forward in the direction you are facing\nleft - Will change your direction 90 degrees to the Left\nright - Will change your direction 90 degrees to the Right\nreport - Provides you with an update to your location on the board\nexit - Terminates the application\n");
            Console.WriteLine();
            while (inGame)
            {
                Console.WriteLine("_____oOOoo___ε(´סּ ˛ סּ`)з___оoOOo_____");
                Console.WriteLine("Options: move, right, left, exit\n");
                Console.WriteLine($"Current Facing Direction: {direction}");
                Console.WriteLine($"X = {locX} | Y = {locY}\n");
                Console.Write("Your Input: ");
                input = Console.ReadLine();
                HandleOptions();
            }
        }
        static void HandleOptions()
        {
            switch (input.ToLower())
            {
                case "move":
                    Move();
                    break;
                case "right":
                    Turn();
                    break;
                case "left":
                    Turn();
                    break;
                case "exit":
                    Exit();
                    break;
                default:
                    Console.WriteLine($"Invalid input '{input}', try again");
                    break;
            }
        }
        static void Turn()
        {
            if(input == "right")
            {
                var dirIndex = directions.IndexOf(direction); // Find the index of the current direction

                dirIndex += 1; // Increment through the index by 1

                if (dirIndex >= directions.Count) // Is indev greater or equal to the amount of elements in directions?
                {
                    direction = directions[0]; // If it is, set it to the first element in the array
                }
                else
                {
                    direction = directions[dirIndex]; // Otherwise set it to the direction next in the array
                }
                Console.WriteLine($"You are now facing the direction {direction}");
            }
            else if (input == "left")
            {
                var dirIndex = directions.IndexOf(direction);

                dirIndex -= 1;

                if (dirIndex <= -1)
                {
                    direction = directions[3]; // Hard coded this, but im sure there is a better way to increment through the List

                }
                else
                {
                    direction = directions[dirIndex];
                }

                Console.WriteLine($"You are now facing the direction {direction}");
            }
        }
        static void Move()
        {
            if (WillFall()) // If WillFall returns true we reject the player falling off the table and making a move
            {
                Console.WriteLine("I’M SORRY DAVE, I’M AFRAID I CAN’T DO THAT");
                Console.WriteLine("(You will fall off the table, please try again)\n");
                return;
            }
            switch (direction) // Otherwise we Switch and increment/decrement through the X/Y coords moving across the table.
            {
                case "north":
                    locY++;
                    break;
                case "south":
                    locY--;
                    break;
                case "west":
                    locX--;
                    break;
                case "east":
                    locX++;
                    break;
            }
        }
        static bool WillFall() // WillFall calculates if the robot will drop off the table and sets it to a boolean
        {
            switch (direction)
            {
                case "north":
                    if (locY + 1 > 5)
                        return true;
                    break;
                case "south":
                    if (locY - 1 < 0)
                        return true;
                    break;
                case "west":
                    if (locX - 1 < 0)
                        return true;
                    break;
                case "east":
                    if (locX + 1 > 5)
                        return true;
                    break;
            }
            return false;
        }
        static void Exit()
        {
            Console.WriteLine("Thanks for playing 😊");
            Environment.Exit(0);
        }
    }
}
