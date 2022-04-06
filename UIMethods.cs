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
        /// Stores user input and converts to Integer. Anything outside of 1-8 will be caught by the try-catch statement.
        /// </summary>
        /// <returns>Integer, between 1-8</returns>
        public static int PromptUserNumberEntry()
        {
            Console.Write("Enter the number of lines you want to play (max 8): ");
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

        /// <summary>
        /// Outputs the players winnings to the console.
        /// </summary>
        /// <param name="winAmount"></param>
        public static void PrintWinnings(int winAmount)
        {
            if (winAmount > 0) // minimum win is £1 for a horizonal line
            {
                Console.WriteLine($"You have some winning rows!");
            }
            Console.WriteLine($"Total winnings: £{winAmount}");
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
