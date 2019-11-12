using Xunit;

namespace CellsWithOddValues.Tests
{
    public class SolutionShould
    {
        [Fact]
        public void GetNumbersOfOddNumbers()
        {
            // Arrange
            Solution sut = new Solution();
            int[][] indicesTestArray1 = new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 } };
            int[][] indicesTestArray2 = new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 } };

            // Act

            // Assert
            Assert.Equal(6, sut.OddCells(2, 3, indicesTestArray1));
            Assert.Equal(0, sut.OddCells(2, 2, indicesTestArray2));
        }
    }
}
