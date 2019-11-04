using System.Collections.Generic;

namespace OutermostParentheses_CSharp.Tests
{
    public class SolutionShouldTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { "(()())(())", "()()()" };
                yield return new object[] { "(()())(())(()(()))", "()()()()(())" };
                yield return new object[] { "()()", "" };
            }
        }
    }
}
