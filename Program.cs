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
            int[] winningRow = { 2, 2, 2 };
            int counter = 0;
            int winnings = 0;

            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    gameGrid[i, j] = random.Next(0, 3);
                    Console.Write(gameGrid[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Enter your wager (in whole £): ");
            playerWager = Convert.ToInt32(Console.ReadLine());
            int[] topHLine = { gameGrid[0, 0], gameGrid[0, 1], gameGrid[0, 2] };
            int[] middleHLine = { gameGrid[1, 0], gameGrid[1, 1], gameGrid[1, 2] };
            int[] bottomHLine = { gameGrid[2, 0], gameGrid[2, 1], gameGrid[2, 2] };

            int[] topVLine = { gameGrid[0, 0], gameGrid[0, 1], gameGrid[0, 2] };
            int[] middleVLine = { gameGrid[1, 0], gameGrid[1, 1], gameGrid[1, 2] };
            int[] bottomVLine = { gameGrid[2, 0], gameGrid[2, 1], gameGrid[2, 2] };

            int[] dLine = { gameGrid[0, 0], gameGrid[1, 1], gameGrid[2, 2] };
            int[] dLine2 = { gameGrid[0, 2], gameGrid[1, 1], gameGrid[2, 0] };

            if (topHLine == winningRow)
            {
                winnings += playerWager;
                counter++;
            }

            if (middleHLine == winningRow)
            {
                winnings += playerWager;
                counter++;
            }

            if (bottomHLine == winningRow)
            {
                winnings += playerWager;
                counter++;
            }

            if (topVLine == winningRow)
            {
                winnings += (playerWager * 2);
                counter++;
            }

            if (middleVLine == winningRow)
            {
                winnings += (playerWager * 2);
                counter++;
            }

            if (bottomVLine == winningRow)
            {
                winnings += (playerWager * 2);
                counter++;
            }

            if (dLine == winningRow)
            {
                winnings += (playerWager * 3);
                counter++;
            }

            if (dLine2 == winningRow)
            {
                winnings += (playerWager * 3);
                counter++;
            }
            //else
            //{
            //    Console.WriteLine($"Unlucky - play again!");
            //}
            Console.WriteLine($"Total winnings: £{winnings}");
        }
    }
}