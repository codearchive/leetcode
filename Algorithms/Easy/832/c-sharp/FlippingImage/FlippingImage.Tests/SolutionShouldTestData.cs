using System.Collections.Generic;

namespace FlippingImage.Tests
{
    public class SolutionShouldTestData
    {
        static int[][] inputArray_0 = new int[][] { new int[] { 0, 1, 0, 0, 1 },
                                                    new int[] { 1, 1, 0, 0, 1 },
                                                    new int[] { 0, 0, 1, 0, 1 },
                                                    new int[] { 1, 1, 0, 0, 1 } };

        static int[][] resultArray_0 = new int[][] { new int[] { 0, 1, 1, 0, 1 },
                                                     new int[] { 0, 1, 1, 0, 0 },
                                                     new int[] { 0, 1, 0, 1, 1 },
                                                     new int[] { 0, 1, 1, 0, 0 } };

        static int[][] inputArray_1 = new int[][] { new int[] { 0, 1, 0, 0, 1, 0 },
                                                    new int[] { 1, 1, 0, 0, 1, 1 },
                                                    new int[] { 0, 0, 1, 0, 1, 0 },
                                                    new int[] { 1, 1, 0, 0, 1, 1 } };

        static int[][] resultArray_1 = new int[][] { new int[] { 1, 0, 1, 1, 0, 1 },
                                                     new int[] { 0, 0, 1, 1, 0, 0 },
                                                     new int[] { 1, 0, 1, 0, 1, 1 },
                                                     new int[] { 0, 0, 1, 1, 0, 0 } };

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { inputArray_0, resultArray_0 };
                yield return new object[] { inputArray_1, resultArray_1 };
            }
        }
    }
}
