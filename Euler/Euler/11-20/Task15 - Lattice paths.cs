using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task15
    {
        private long[][] grid;
        private readonly int MAX_ROW;
        private readonly int MAX_COLUMN;

        public Task15(int maxRow, int maxColumn)
        {
            MAX_ROW = maxRow;
            MAX_COLUMN = maxColumn;
            grid = new long[MAX_ROW + 1][];
            for (int i = 0; i <= MAX_ROW; ++i)
            {
                grid[i] = new long[MAX_COLUMN + 1];
            }
            for (int column = 0; column < MAX_COLUMN; column++)
            {
                grid[column][MAX_ROW] = 1;
            }
            for (int i = 0; i < MAX_ROW; i++)
            {
                grid[MAX_COLUMN][i] = 1;
            }
        }

        public long Run()
        {
            for (int row = MAX_ROW - 1; row >= 0; row--)
            {
                for (int col = MAX_COLUMN - 1; col >= 0; col--)
                {
                    grid[row][col] = grid[row + 1][col] + grid[row][col + 1];
                }
            }
            return grid[0][0];
        }
    }
}
