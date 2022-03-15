using System;

namespace NumberSlot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] gameGrid = new int[3, 3];
            
            for(int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for(int j = 0; j < gameGrid.GetLength(1); j++)  
                {
                    gameGrid[i, j] = random.Next(0, 3);
                    Console.Write(gameGrid[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}