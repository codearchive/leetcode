using System;
using System.Collections.Generic;
using System.Text;

namespace SortArrayByParity.Tests
{
    public class SolutionShouldTestData
    {
        static int[] inputArray_0 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        static int[] resultArray_0 = new int[] { 6, 2, 4, 3, 5, 1, 7 };

        static int[] inputArray_1 = new int[] { 3, 1, 2, 4 };

        static int[] resultArray_1 = new int[] {4, 2, 1, 3};

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
