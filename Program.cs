using System;

namespace NumberSlot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] slotGrid = new int[3, 3];
            int numberOfRows;
            int winnings = 0;
            int[] winningCombo = new int[3] { 2, 2, 2 };
            slotGrid = Grid.GenerateGrid();

            Grid.DisplayGrid(slotGrid);
            Console.Write("Enter the number of lines you want to play: ");
            numberOfRows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < slotGrid.GetLength(0); i++) //iterates through every line
            {
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
                if (slotGrid[i, 0] == winningCombo[0] && slotGrid[i, 1] == winningCombo[1] && slotGrid[i, 2] == winningCombo[2])
                {
                    winnings++;
                }
            }

            if (winnings > 1)
            {
                Console.WriteLine($"You have some winning rows!");
            }
            Console.WriteLine();
            Console.WriteLine($"Total winnings: £{winnings}");
        }
    }

    public static class Grid
    {
        public static int[,] GenerateGrid()
        {
            Random random = new Random();
            int[,] gameGrid = new int[3, 3];
            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    gameGrid[i, j] = random.Next(0, 3);
                }
            }
            return gameGrid;
        }

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
    }
}