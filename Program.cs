using System;
using Mission2DiceApp;


// Name: Eli Baker
// Description: this program asks a user for a roll number and then automatically rolls the dice for that
namespace Mission2DiceApp
{
        internal class Program
    {
        // first class with the main method that runs the project
        private static void Main(string[] args)
        {
            // introductory print statement
            Console.WriteLine("Welcome to the dice throwing simulator!");

            // initialize a new class instance for each of my two classes
            RollCount rollCount = new RollCount();
            RollSimulator rollSimulator = new RollSimulator();

            // generate a user-inputted target number of rolls using a method within the RollCount class instance
            int userRollNum = rollCount.UserRollNum();

            // print statements to show user inputted number of rolls
            Console.WriteLine("Dice Rolling Simulation Results");
            Console.WriteLine("Total Number of Rolls: " + userRollNum);

            // generate an array of integers representing each of the dice rolls by using the value passed by the first class
            int[] rollNumbers = rollSimulator.RollSim(userRollNum);

            // create and print the output by passing the values from the second class back to the first class
            string diceOutput = rollCount.DiceOutput(rollNumbers, userRollNum);
            Console.WriteLine(diceOutput);
        }
    }
}
