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
               
                Console.Write("Enter the number of lines you want to play (max 8): ");
                try
                {
                    numberOfRows = Convert.ToInt32(Console.ReadLine());
                    
                    switch (numberOfRows)
                    {
                        case 1:
                        case 2:
                        case 3:
                            {
                                winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                                break;
                            }
                        case 4:
                        case 5:
                        case 6:
                            {
                                winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                                winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                                break;
                            }
                        case 7:
                        case 8:
                            {
                                winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                                winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                                winnings += Grid.CalculateDiagonalLines(slotGrid, numberOfRows);
                                break;
                            }
                    }

                    if (winnings > 0) // minimum win is £1 for a horizonal line
                    {
                        Console.WriteLine($"You have some winning rows!");
                    }
                    Console.WriteLine($"Total winnings: £{winnings}");
                    winnings = 0; // reset winnings after each spin

                    Console.Write("Spin again? (Y/N) ");
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
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} - invalid value!");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }
    }
}