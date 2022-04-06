using System;

namespace NumberSlot
{
    public static class Grid
    {
        static int[] winningCombo = new int[3] { 2, 2, 2 };
        static int winningsCount = 0;
        public const int MAX_HORIZONTAL_ROWS = 3;
        public const int MAX_VERTICAL_ROWS = 6;

        /// <summary>
        /// Returns a randomly generated 3x3 grid with each position containing a number between 0-2
        /// </summary>
        /// <returns>
        /// a number grid that looks like this:
        /// [n][n][n]
        /// [n][n][n]
        /// [n][n][n]
        /// </returns>
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

        /// <summary>
        /// This method checks the horizontal lines of the slot machine to see if there are any matching lines.
        /// The maximum number of lines is 3, so logic is used to only iterate through 1 or 2 lines if the user opts to play those
        /// </summary>
        /// <param name="slotGrid">2D array of numbers</param>
        /// <param name="lines">a number between 1-3 (based on user input)</param>
        /// <returns>1 for every winning line, or 0</returns>
        public static int CalculateHorizontalLines(int[,] slotGrid, int lines)
        {
            if (lines < MAX_HORIZONTAL_ROWS)
            {
                for (int i = 0; i < lines; i++)
                {
                    if (slotGrid[i, 0] == winningCombo[0] && slotGrid[i, 1] == winningCombo[1] && slotGrid[i, 2] == winningCombo[2])
                    {
                        winningsCount++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < slotGrid.GetLength(0); i++)
                {
                    if (slotGrid[i, 0] == winningCombo[0] && slotGrid[i, 1] == winningCombo[1] && slotGrid[i, 2] == winningCombo[2])
                    {
                        winningsCount++;
                    }
                }
            }
            return winningsCount;
        }

        /// <summary>
        /// This method checks the vertical lines of the slot machine to see if there are any matching lines.
        /// The maximum number of lines is 3, so logic is used to only iterate through 1 or 2 lines if the user opts to play those
        /// However, the player can opt for 1 or 2 vertical lines (in addition to 3 horizontal lines) which is accounted for in the logic.
        /// This method is called in-game after evaluating horizontal lines (if lines > 3)
        /// </summary>
        /// <param name="slotGrid">2D array of numbers</param>
        /// <param name="lines">a number between 4-6 (based on user input)</param>
        /// <returns>2 for each winning line, or 0</returns>
        public static int CalculateVerticalLines(int[,] slotGrid, int lines)
        {
            if (lines < MAX_VERTICAL_ROWS)
            {
                for (int j = 0; j < (lines - slotGrid.GetLength(1)); j++)
                {
                    if (slotGrid[0, j] == winningCombo[0] && slotGrid[1, j] == winningCombo[1] && slotGrid[2, j] == winningCombo[2])
                    {
                        winningsCount += 2;
                    }
                }
            }
            else 
            {
                for (int j = 0; j < (slotGrid.GetLength(1)); j++)
                {
                    if (slotGrid[0, j] == winningCombo[0] && slotGrid[1, j] == winningCombo[1] && slotGrid[2, j] == winningCombo[2])
                    {
                        winningsCount += 2;
                    }
                }
            }
            return winningsCount;
        }
        /// <summary>
        /// This method checks the diagonal lines of the slot machine to see if there are any matching lines.
        /// Slot grid positions are hard-coded and evaluated against the `winningCombo` array values
        /// This method is called in-game after evaluating horizontal AND vertical lines ((if lines > 7)
        /// </summary>
        /// <param name="slotGrid">2D array of numbers</param>
        /// <param name="lines">a number between 7-8 (based on user input)</param>
        /// <returns>3 for a winning line, or 0</returns>
        public static int CalculateDiagonalLines(int[,] slotGrid, int lines)
        {
            if (lines == 8)
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
    }
}
