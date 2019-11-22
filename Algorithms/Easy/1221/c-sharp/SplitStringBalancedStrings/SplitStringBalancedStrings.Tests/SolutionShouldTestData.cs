using System.Collections.Generic;

namespace SplitStringBalancedStrings.Tests
{
    public class SolutionShouldTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { "RLRRLLRLRL", 4 };
                yield return new object[] { "RLLLLRRRLR", 3 };
                yield return new object[] { "LLLLRRRR", 1 };
                yield return new object[] { "RLRRRLLRLL", 2 };
                yield return new object[] { "RRLRRLRLLLRL", 2 };
            }
        }
    }
}
