using Xunit;

namespace SortArrayByParity.Tests
{
    public class SolutionShould
    {
        [Theory]
        [MemberData(nameof(SolutionShouldTestData.TestData), MemberType = typeof(SolutionShouldTestData))]
        public void SortArray(int[] inputArray, int[] resultArray)
        {
            //Arrange
            Solution sut = new Solution();

            //Act

            //Assert
            Assert.Equal(resultArray, sut.SortArrayByParity(inputArray));
        }
    }
}
