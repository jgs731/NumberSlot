﻿using System;

namespace NumberSlot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] slotGrid = new int[3, 3];
            int numberOfRows;
            int playerMoneyPot;
            int winnings = 0;
            bool continueSpinning = true;

            playerMoneyPot = UIMethods.PromptUserMoneyPot();
            while (continueSpinning)
            {
                slotGrid = Grid.GenerateGrid();
                UIMethods.DisplayGrid(slotGrid);
                try
                {
                    numberOfRows = UIMethods.PromptUserNumberEntry();
                    switch (numberOfRows)
                    {
                        case 1:
                        case 2:
                        case 3:
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            break;
                        case 7:
                        case 8:
                            winnings += Grid.CalculateHorizontalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateVerticalLines(slotGrid, numberOfRows);
                            winnings += Grid.CalculateDiagonalLines(slotGrid, numberOfRows);
                            break;
                    }
                    UIMethods.PrintWinnings(winnings);
                    winnings = 0; // reset winnings after each spin
                    playerMoneyPot = playerMoneyPot - numberOfRows;
                    UIMethods.DisplayRemainingPot(playerMoneyPot);
                    if (UIMethods.SpinAgainPrompt() == false)
                    {
                        continueSpinning = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} - invalid amount!");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }
    }
}