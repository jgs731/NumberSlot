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
            bool continueSpinning = true;

            while (continueSpinning)
            {
                slotGrid = Grid.GenerateGrid();
                Grid.DisplayGrid(slotGrid);
                Console.Write("Enter the number of lines you want to play: ");
                numberOfRows = Convert.ToInt32(Console.ReadLine());
                switch (numberOfRows)
                {
                    case 1:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 2:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 3:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 4:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 5:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 6:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 7:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 8:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateDiagonalLines(slotGrid, numberOfRows);
                            break;
                        }
                    case 9:
                        {
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateDiagonalLines(slotGrid, numberOfRows);
                            break;
                        }
                }

                if (winnings > 1)
                {
                    Console.WriteLine($"You have some winning rows!");
                }
                Console.WriteLine($"Total winnings: £{winnings}");

                Console.Write("Do you want another spin? (Y/N) ");
                string response = Console.ReadLine();
                if (response.ToUpper() == "N")
                {
                    continueSpinning = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }

    public static class Grid
    {
        static int[] winningCombo = new int[3] { 2, 2, 2 };
        static int winningsCount = 0;
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

        public static int CalculateHorizontalLines(int[,] slotGrid, int lines)
        {
            for (int i = 0; i < slotGrid.GetLength(0); i++)
            {
                if (lines == 1)
                {
                    if (slotGrid[1, 0] == winningCombo[0] && slotGrid[1, 1] == winningCombo[1] && slotGrid[1, 2] == winningCombo[2])
                    {
                        winningsCount++;
                    }
                }
                else
                { 
                    if (slotGrid[i, 0] == winningCombo[0] && slotGrid[i, 1] == winningCombo[1] && slotGrid[i, 2] == winningCombo[2])
                    {
                        winningsCount++;
                    }
                }
            }
            return winningsCount;
        }

        public static int CalculateVerticalLines(int[,] slotGrid, int lines)
        {
            if (lines > 6)
            {
                for (int j = 0; j < (lines - slotGrid.GetLength(0) - slotGrid.GetLength(1)); j++)
                {
                    if (slotGrid[0, j] == winningCombo[0] && slotGrid[1, j] == winningCombo[1] && slotGrid[2, j] == winningCombo[2])
                    {
                        winningsCount += 2;
                    }
                }
            }
            else
            {
                for (int j = 0; j < (lines - slotGrid.GetLength(1)); j++)
                {
                    if (slotGrid[0, j] == winningCombo[0] && slotGrid[1, j] == winningCombo[1] && slotGrid[2, j] == winningCombo[2])
                    {
                        winningsCount += 2;
                    }
                }
            }
            return winningsCount;
        }

        public static int CalculateDiagonalLines(int[,] slotGrid, int lines)
        {
            if (lines == 9)
            {
                if (slotGrid[0, 0] == winningCombo[0] && slotGrid[1, 1] == winningCombo[1] && slotGrid[2, 2] == winningCombo[2])
                {
                    winningsCount =+ 3;
                }
            }

            if (slotGrid[0, 2] == winningCombo[0] && slotGrid[1, 1] == winningCombo[1] && slotGrid[2, 0] == winningCombo[2])
            {
                winningsCount =+ 3;
            }

            return winningsCount;
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