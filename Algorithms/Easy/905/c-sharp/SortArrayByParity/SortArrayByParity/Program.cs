using System;

namespace SortArrayByParity
{
    public class Program
    {
        public static void Main()
        {
            Solution sln = new Solution();

            int[] inputArray = new int[]{ 3, 1, 5, 2, 4 };

            Console.WriteLine("Input array:");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
            Console.WriteLine();

            
            inputArray = sln.SortArrayByParity(inputArray);

            Console.WriteLine("Output array:");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}
