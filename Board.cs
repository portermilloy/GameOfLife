using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class Board
    {
        private bool[,] grid;
        private int rows = 100;
        private int cols = 100;

        public Board()
        {
            grid = new bool[rows, cols];
        }

        public void PrintBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(grid[r, c]);
                }
                Console.WriteLine();
            }
        }

        public void ClearBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = false;
                }
            }
        }

    }
}
