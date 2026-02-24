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
        private int rows = 10;
        private int cols = 10;

        public Board()
        {
            grid = new bool[rows, cols];
            grid[6, 5] = true;
            grid[5, 6] = true;
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

        public bool IsAlive(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                return false;
            }

            return grid[row, col];
        }

        public int CountNeighbors(int row, int col)
        {
            int count = 0;

            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = col - 1; c <= col + 1; c++)
                {
                    if (r == row && c == col)
                    {
                        continue;
                    }
                    
                    if (IsAlive(r, c))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

    }
}
