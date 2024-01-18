using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2DiceApp
{
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
}
