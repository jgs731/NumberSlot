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
            if (playerWager == 7 || playerWager == 8)
            {
                //diagonal
                for (int i = 0; i < gameGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < (gameGrid.GetLength(1) - i); j--)
                    {
                        int jEdit = Math.Abs(i);
                        if (gameGrid[0, jEdit] == gameGrid[1, jEdit] && gameGrid[1, jEdit] == gameGrid[2, jEdit])
                        {
                            winnings += 3;
                        }
                    }
                }
            }
            else if (playerWager >= 3 && playerWager < 6)
            {
                // vertical
                for (int i = 0; i < gameGrid.GetLength(1); i++)
                {
                    if (gameGrid[0, i] == gameGrid[1, i] && gameGrid[i, 1] == gameGrid[2, i])
                    {
                        winnings += 2;
                    }
                }
            }
            // horizontal
            else if (playerWager > 1 && playerWager < 3)
            {
                for (int i = 0; i < gameGrid.GetLength(0); i++)
                {
                    if (gameGrid[i, 0] == gameGrid[i, 1] && gameGrid[i, 1] == gameGrid[i, 2])
                    {
                        winnings++;
                    }
                }
            }
            else
            {
                if (gameGrid[1, 0] == gameGrid[1, 1] && gameGrid[1, 1] == gameGrid[1, 2])
                {
                    winnings++;
                }
            }
            Console.WriteLine($"Total winnings: £{winnings}");
        }
    }
}