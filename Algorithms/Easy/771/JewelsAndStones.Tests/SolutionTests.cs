using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JewelsAndStones.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void StonesDoNotHaveJewels()
        {
            // Arrange
            var expected0 = Solution.JewelsCounter("aA", "");
            var expected1 = Solution.JewelsCounter("", "aAAbb");
            var expected2 = Solution.JewelsCounter("", "");

            // Act
            var actual = 0;

            // Assert
            Assert.AreEqual(expected0, actual);
            Assert.AreEqual(expected1, actual);
            Assert.AreEqual(expected2, actual);
        }

        [TestMethod]
        public void StonesDoHaveConcreteNumberOfJewels()
        {
            // Arrange
            var expected0 = Solution.JewelsCounter("aA", "aAAbb");
            var expected1 = Solution.JewelsCounter("aAb", "aAAbbc");
            var expected2 = Solution.JewelsCounter("aA", "AAbbaa");

            // Act
            var actual0 = 3;
            var actual1 = 5;
            var actual2 = 4;

            // Assert
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
