using System;
using System.Collections.Generic;

namespace ToyRobot
{
    class Program
    {
        static bool inGame = true;
        static string input;
        static string direction = "north";
        static List<string> directions = new List<string>() { "north", "east", "south", "west" };
        static int locX = 0;
        static int locY = 0;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Welcome to Toy Robot!");
            Console.WriteLine();
            Console.WriteLine("Hi, Welcome to the robot challenge\nYou are a robot on a 5x5 table placed on the South West corner\nThe inputs to play the game are\nPlace - Will place you on the board\nMove - Will move you one step forward in the direction you are facing\nLeft - Will change your direction 90 degrees to the Left\nRight - Will change your direction 90 degrees to the Right\nReport - Provides you with an update to your location on the board\nExit - Terminates the application\n");
            Console.WriteLine("Options: move, right, left, exit");
            Console.WriteLine();
            while (inGame)
            {
                Console.WriteLine($"Current Facing Direction: {direction}");
                Console.WriteLine("X = {0} | Y = {1}", locX, locY);
                Console.Write("Your Input: ");
                input = Console.ReadLine();
                HandleOptions();
            }
        }
        static void HandleOptions()
        {
            switch (input.ToLower())
            {
                //case "place":
                //    Place();
                //    break;
                case "move":
                    Move();
                    break;
                case "right":
                    Right();
                    break;
                //case "left":
                //    Left();
                //    break;
                //case "report":
                //    Report();
                //    break;
                case "exit":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid input '{0}', try again", input);
                    break;
            }
        }
        //static void Place()
        //{

        //}
        static void Right() // This is just some bullshit
        {
            var dirIndex = directions.IndexOf(direction); // Find the index of the current direction
            // E.G north will be 0, south will be 2
            dirIndex = dirIndex + 1; // Now if we were 'west' it would be 3 + 1 = 4
            if (dirIndex >= directions.Count) // Is 4 greater or equal to the amount of elements in directions?
            {
                direction = directions[0]; // If it is, set it to the first element in the array (back at the start)
            }
            else
            {
                direction = directions[dirIndex]; // Otherwise set it to the direction next in the array
            }
            Console.WriteLine("You are now facing the direction {0}", direction);
        }
        //static void Left()
        //{

        //}
        static void Move()
        {
            if (WillFall())
            {
                Console.WriteLine("Doing that will make you fall off the table");
                return;
            }
            switch (direction)
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
        static bool WillFall()
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
