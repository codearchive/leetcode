using Xunit;

namespace FlippingImage.Tests
{
    public class SolutionShould
    {
        [Theory]
        [MemberData(nameof(SolutionShouldTestData.TestData), MemberType = typeof(SolutionShouldTestData))]
        public void FlipImage(int[][] inpArr, int[][] resArr)
        {
            //Arrange
            Solution sut = new Solution();

            //Act

            //Assert
            Assert.Equal(resArr, sut.FlipAndInvertImage(inpArr));
        }
    }
}
