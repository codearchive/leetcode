using Xunit;

namespace OutermostParentheses_CSharp.Tests
{
    public class SolutionShould
    {
        [Theory]
        [MemberData(nameof(SolutionShouldTestData.TestData), MemberType = typeof(SolutionShouldTestData))]
        public void RemoveOutermostParentheses(string inputString, string expectedString)
        {
            //Arrange
            Solution sut = new Solution();

            //Act

            //Assert
            Assert.Equal(expectedString, sut.RemoveOuterParentheses(inputString));
        }
    }
}
