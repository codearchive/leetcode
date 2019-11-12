using System;
using System.Collections.Generic;

namespace CellsWithOddValues
{
    public class Solution
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            int oddCounter = 0;

            int[,] basicArray = new int[n, m];

            Dictionary<int, int> dictIndicesRows = new Dictionary<int, int>();
            Dictionary<int, int> dictIndicesColumns = new Dictionary<int, int>();

            for (int i = 0; i < Math.Max(n, m); i++)
            {
                dictIndicesRows.Add(i, 0);
                dictIndicesColumns.Add(i, 0);
            }

            for (int i = 0; i < indices.Length; i++)
            {
                dictIndicesRows[indices[i][0]]++;
                dictIndicesColumns[indices[i][1]]++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    basicArray[i, j] += (dictIndicesRows[i] + dictIndicesColumns[j]);
                    if (basicArray[i, j] % 2 == 1) oddCounter++;
                }
            }

            return oddCounter;
        }
    }
}
