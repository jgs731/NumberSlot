using System;

namespace NumberSlot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] gameGrid = new int[3, 3];
            int playerWager;
            int winnings = 0;
            int[] winningCombo = new int[3] { 2, 2, 2 };

            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    gameGrid[i, j] = random.Next(0, 3);
                    Console.Write(gameGrid[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.Write("Enter the number of lines you want to play: ");
            playerWager = Convert.ToInt32(Console.ReadLine());
            if (gameGrid[1, 0] == winningCombo[0] && gameGrid[1, 1] == winningCombo[1] && gameGrid[1, 2] == winningCombo[2])
            {
                Console.WriteLine($"Your {playerWager} shot was successful!");
                winnings++;
            }
            Console.WriteLine($"Total winnings: £{winnings}");
        }
    }
}