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
            int[] winningCombo1 = new int[3] { 1, 1, 1 };
            int[] winningCombo2 = new int[3] { 2, 2, 2 };
            int[] winningCombo3 = new int[3] { 3, 3, 3 };
            int[][] winningGrid = new int[3][] { winningCombo1, winningCombo2, winningCombo3};

            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    gameGrid[i, j] = random.Next(0, 3);
                    Console.Write(gameGrid[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.Write("Enter the number of lines you want to play (Max 8): ");
            playerWager = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gameGrid.GetLength(1); i++)
            {
                //diagonal
                if (gameGrid[0, 0] == winningGrid[0][0]
                    && gameGrid[1, 1] == winningGrid[1][1]
                    && gameGrid[2, 2] == winningGrid[2][2])
                {
                    winnings += 3;
                }

                if (gameGrid[0, 2] == winningGrid[0][2]
                    && gameGrid[1, 1] == winningGrid[1][1]
                    && gameGrid[2, 0] == winningGrid[2][0])
                {
                    winnings += 3;
                }

                // vertical
                if (gameGrid[0, i] == winningGrid[0][0]
                    && gameGrid[1, i] == winningGrid[0][1]
                    && gameGrid[2, i] == winningGrid[0][2])
                {
                    winnings += 2;
                }
                // horizontal
                if (gameGrid[i, 0] == winningGrid[0][0]
                    && gameGrid[i, 1] == winningGrid[0][1]
                    && gameGrid[i, 2] == winningGrid[0][2])
                {
                    winnings++;
                }
            }
            Console.WriteLine($"Total winnings: £{winnings}");
        }
    }
}