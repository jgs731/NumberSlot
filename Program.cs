using System;

namespace NumberSlot
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] gameGrid = new int[3, 3];
            int numberOfRows;
            int winnings = 0;
            int[] winningCombo = new int[3] { 2, 2, 2 };

            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    gameGrid[i, j] = random.Next(0, 3);
                }
            }

            Console.Write("Enter the number of lines you want to play: ");
            numberOfRows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gameGrid.GetLength(0); i++) //iterates through every line
            {
                //skip certain lines depeding on numberOFRows
                // maybe some if statements, mybe a switch case ;)
                switch (numberOfRows)
                {
                    case 1:
                    {
                        if (i != 1)
                        {
                            continue;
                        }
                        break;
                    }
                    case 2:
                    {
                        if (i == 1)
                        {
                            continue;
                        }
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
                if (gameGrid[i, 0] == winningCombo[0] && gameGrid[i, 1] == winningCombo[1] && gameGrid[i, 2] == winningCombo[2])
                {
                    winnings++;
                }
            }

            if (winnings > 1)
            {
                Console.WriteLine($"You have some winning rows!");
            }
            Console.WriteLine($"Total winnings: £{winnings}");
        }
    }
}