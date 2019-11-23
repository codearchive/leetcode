using System;

namespace FlippingImage
{
    public class Program
    {
        public static void Main()
        {
            Solution sln = new Solution();

            int[][] inputArray = new int[][] { new int[] { 0, 1, 0, 0, 1 },
                                               new int[] { 1, 1, 0, 0, 1 },
                                               new int[] { 0, 0, 1, 0, 1 },
                                               new int[] { 1, 1, 0, 0, 1 } };

            Console.WriteLine("Input:");
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray[0].Length; j++)
                {
                    Console.Write($"{inputArray[i][j]} ");
                }

                Console.WriteLine();
            }

            var resultArray = sln.FlipAndInvertImage(inputArray);
            Console.WriteLine("\nOutput:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                for (int j = 0; j < resultArray[0].Length; j++)
                {
                    Console.Write($"{resultArray[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
