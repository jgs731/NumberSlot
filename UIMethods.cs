using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSlot
{
    internal static class UIMethods
    {
        /// <summary>
        /// Number slot grid is generated and displayed to user with tab formatting between each number
        /// </summary>
        /// <param name="slotGrid">2D number array</param>
        public static void DisplayGrid(int[,] slotGrid)
        {
            for (int i = 0; i < slotGrid.GetLength(0); i++)
            {
                for (int j = 0; j < slotGrid.GetLength(1); j++)
                {
                    Console.Write(slotGrid[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Stores user input for money inserted into the slot machine
        /// </summary>
        /// <returns>An Integer larger than 0</returns>
        public static int PromptUserMoneyPot()
        {
            Console.Write("How much money do you want to insert (in whole £)? ");
            int playerCashPot = Convert.ToInt32(Console.ReadLine());
            if (playerCashPot > 0) {
                return playerCashPot;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Stores user input and converts to Integer. Anything outside of 1-8 will be caught by the try-catch statement.
        /// </summary>
        /// <returns>Integer, between 1-8</returns>
        public static int PromptUserNumberEntry()
        {
            Console.Write("Enter £1 per line to play (8 lines max): ");
            int playerLines = Convert.ToInt32(Console.ReadLine());
            if (playerLines >= 1 && playerLines <= 8)
            {
                return playerLines;
            }
            else
            {
                return 0;
            }
        }

        public static void DisplayRemainingPot(int remainingMoneyInPot)
        {
            if (remainingMoneyInPot <= 0)
            {
                Console.WriteLine("You have run out of money - no more lines can be played!");
            }
            else
            {
                Console.WriteLine($"You have £{remainingMoneyInPot} to play with");
            }
        }

        /// <summary>
        /// Outputs the players winnings to the console.
        /// </summary>
        /// <param name="winAmount">player winning amount (in £)</param>
        public static void PrintWinnings(int winAmount)
        {
            // minimum win is £1 for a horizonal line
            Console.WriteLine((winAmount > 0) ? $"You win! Total winnings: £{winAmount}" : "Unlucky, no winning lines");
        }

        /// <summary>
        /// Asks user if they want to play again. Y will restart the game, N will exit
        /// </summary>
        /// <returns>True ("Y"), False ("N")</returns>
        public static bool SpinAgainPrompt()
        {
            Console.Write("Spin again? (Y/N) ");
            string response = Console.ReadLine();
            if (response.ToUpper() == "N")
            {
                return false;
            }
            else
            {
                Console.Clear(); // clear Console for next spin
                return true;
            }
        }
    }
}
