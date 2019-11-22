using Xunit;

namespace SplitStringBalancedStrings.Tests
{
    public class SolutionShould
    {
        [Theory]
        [MemberData(nameof(SolutionShouldTestData.TestData), MemberType = typeof(SolutionShouldTestData))]
        public void CountBalancedSubstrings(string inputString, int expectedNumbersOfBalancedSubstrings)
        {
            //Arrange
            Solution sut = new Solution();

            //Act

            //Assert
            Assert.Equal(expectedNumbersOfBalancedSubstrings, sut.BalancedStringSplit(inputString));
        }
    }
}
