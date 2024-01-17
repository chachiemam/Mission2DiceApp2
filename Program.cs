using System;

// Name: Eli Baker
// Description: this program asks a user for a roll number and then automatically rolls the dice for that
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

// first class, which will pass a value to the second class and then receive values back from that second class 
public class RollCount
{
    //method that allows a user to input their desired number of rolls
    public int UserRollNum()
    {
        // initialize the variable that will receive the user's input
        int RollCount;

        // ask the user for roll count
        Console.WriteLine("How many rolls would you like?");

        // make the roll count the equivalent of what the user types in
        RollCount = int.Parse(Console.ReadLine());

        // returns RollCount to be able to pass it to the other class
        return RollCount;
    }

    // method to generate the output that the user will see 
    public string DiceOutput(int[] rollNumbers, int userRollNum)
    {
        // initialize all of the variables
        string output = "";
        int rollNumIndicator = 2;
        int asterisksNum = 0;

        // for loop to go through the number of rolls per number and then add some asterisks
        for (int i = 0; i < rollNumbers.Length; i++)
        {
            // initializing new variables inside the for loop, including one that generates a percentage rounded down.
            int totalCount = rollNumbers[i];
            string asterisks = "";
            double totalCountPercentage = Math.Floor(((double)totalCount / userRollNum) * 100);

            // for loop to generate the asterisks based on the percentage
            for (int j = 0; j < totalCountPercentage; j++)
            {
                asterisks += "*";
                asterisksNum++;
            }

            // adding all of the outputs together
            output += rollNumIndicator + ": " + asterisks + "\n";
            rollNumIndicator++;
        }
        // adds the number of asterisks to the bottom of the output to ensure almost 100 asterisks are present
        output = output + "\n" + asterisksNum + " asterisks present.";
        return output;
    }
}

// new class that takes the user-inputted rollCount and outputs an array back to the first class to be read and create a dynamic output
public class RollSimulator
{
    // initialize a new array with 11 slots (for numbers 2-12)
    int[] RollNumbers = new int[11];

    // method to roll the dice and store the totals to the array
    public int[] RollSim(int RollCountPass)
    {
        // new random object declaration
        Random random = new Random(); 

        // for loop to roll the dice for all of the proposed rolls
        for (int i = 1; i <= RollCountPass; i++)
        {
            // random rolls of the dice for two dice, and then adding them together
            int DiceRollOutcome1 = random.Next(1, 7);
            int DiceRollOutcome2 = random.Next(1, 7);
            int DiceRollOutcomeTotal = DiceRollOutcome1 + DiceRollOutcome2;

            // updating the array with a +1 to wherever the number is stored
            RollNumbers[DiceRollOutcomeTotal - 2]++;
        }
        // returning the array to be passed to the first class for output generation
        return RollNumbers;
    }
}
