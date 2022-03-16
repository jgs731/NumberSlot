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
            
            for(int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for(int j = 0; j < gameGrid.GetLength(1); j++)  
                {
                    gameGrid[i, j] = random.Next(0, 3);
                    Console.Write(gameGrid[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Enter your wager (in whole £): ");
            playerWager = Convert.ToInt32(Console.ReadLine());
            if (gameGrid[1, 0] == gameGrid[1, 1] && gameGrid[1, 1] == gameGrid[1, 2])
            {
                winnings += (playerWager * 3);
                Console.WriteLine($"Total winnings: £{winnings}");
            }
            else
            {
                Console.WriteLine($"Unlucky - play again!");
            }
        }
    }
}