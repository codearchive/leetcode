using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueMorseCodeWords.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestMethodWithDictionary()
        {
            // Arrange
            string[] inputStrings = {"vtpke", "vngc", "vnqr", "gbzx", "qvdx"};
            string expected0 = "...--.--.-.-.";
            string expected1 = "...--.--.-.-.";
            string expected2 = "...--.--.-.-.";
            string expected3 = "--.-...--..-..-";
            string expected4 = "--.-...--..-..-";

            // Act
            string actual0 = Solution.WordToMorseCodeTransformationUsingDict(inputStrings[0]);
            string actual1 = Solution.WordToMorseCodeTransformationUsingDict(inputStrings[1]);
            string actual2 = Solution.WordToMorseCodeTransformationUsingDict(inputStrings[2]);
            string actual3 = Solution.WordToMorseCodeTransformationUsingDict(inputStrings[3]);
            string actual4 = Solution.WordToMorseCodeTransformationUsingDict(inputStrings[4]);

            // Assert
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        [TestMethod]
        public void TestMethodWithString()
        {
            // Arrange
            string[] inputStrings = { "vtpke", "vngc", "vnqr", "gbzx", "qvdx" };
            string expected0 = "...--.--.-.-.";
            string expected1 = "...--.--.-.-.";
            string expected2 = "...--.--.-.-.";
            string expected3 = "--.-...--..-..-";
            string expected4 = "--.-...--..-..-";

            // Act
            string actual0 = Solution.WordToMorseCodeTransformationUsingString(inputStrings[0]);
            string actual1 = Solution.WordToMorseCodeTransformationUsingString(inputStrings[1]);
            string actual2 = Solution.WordToMorseCodeTransformationUsingString(inputStrings[2]);
            string actual3 = Solution.WordToMorseCodeTransformationUsingString(inputStrings[3]);
            string actual4 = Solution.WordToMorseCodeTransformationUsingString(inputStrings[4]);

            // Assert
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        [TestMethod]
        public void AddingUniqueWordsToHashSet()
        {
            // Arrange
            string[] inputStrings = { "vtpke", "vngc", "vnqr", "gbzx", "qvdx" };
            int expected = 2;

            // Act
            int actual = Solution.UniqueMorseRepresentations(inputStrings);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
