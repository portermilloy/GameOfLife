using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class Board
    {
        private bool[,] grid;
        private int rows = 25;
        private int cols = 25;

        public Board()
        {
            grid = new bool[rows, cols];

            grid[12, 13] = true;
            grid[12, 14] = true;

            grid[13, 12] = true;
            grid[13, 15] = true;

            grid[14, 13] = true;
            grid[14, 14] = true;
            grid[14, 15] = true;
        }

        public void PrintBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    
                    if (grid[r, c])
                    {
                        Console.Write("O  ");

                    }
                    else
                    {
                        Console.Write(".  ");
                    }
                    
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

        public void NextGeneration()
        {
            bool[,] nextGeneration = new bool[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int neighbors = CountNeighbors(r, c);

                    if (grid[r, c])
                    {
                        if (neighbors < 2)
                        {
                            nextGeneration[r, c] = false;
                        }
                        else if (neighbors == 2 || neighbors == 3)
                        {
                            nextGeneration[r, c] = true;
                        }
                        else
                        {
                            nextGeneration[r, c] = false;
                        }
                    }
                    else
                    {
                        if (neighbors == 3)
                        {
                            nextGeneration[r, c] = true;
                        }
                        else
                        {
                            nextGeneration[r, c] = false;
                        }
                    }
                }
            }
            grid = nextGeneration;
        }
    }
}
