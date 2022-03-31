using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSlot
{
    internal static class UIMethods
    {
        public static void PromptUserNumberEntry()
        {
            Console.Write("Enter the number of lines you want to play (max 8): ");
        }

        public static void PrintWinnings(int winAmount)
        {
            if (winAmount > 0) // minimum win is £1 for a horizonal line
            {
                Console.WriteLine($"You have some winning rows!");
            }
            Console.WriteLine($"Total winnings: £{winAmount}");
        }

        public static bool SpinAgainPrompt()
        {
            Console.Write("Spin again? (Y/N) ");
            string response = Console.ReadLine();
            if (response.ToUpper() == "N")
            {
                Console.Clear(); // clear Console for next spin
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
