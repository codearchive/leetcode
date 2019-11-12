using System;

namespace CellsWithOddValues
{
    public class Program
    {
        public static void Main()
        {
            int[][] a = new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 } };
            Solution sln = new Solution();
            Console.WriteLine(sln.OddCells(2, 3, a));
            Console.ReadLine();
        }
    }
}
