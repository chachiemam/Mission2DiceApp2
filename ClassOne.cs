using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission2DiceApp;

namespace Mission2DiceApp
{
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
}
