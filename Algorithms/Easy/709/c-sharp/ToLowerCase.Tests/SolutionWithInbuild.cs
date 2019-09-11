using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToLowerCase.Tests
{
    [TestClass]
    public class SolutionWithInbuild
    {
        [TestMethod]
        public void StringInLowerCase()
        {
            // Arrange
            var baseString = "HellO WorLD";
            var expected = Solution.ToLowerCase_WithInbuildFunction(baseString);

            // Act
            var actual = "hello world";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyString()
        {
            // Arrange
            var baseString = "";
            var expected = Solution.ToLowerCase_WithInbuildFunction(baseString);

            // Act
            var actual = "";

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
