using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Defanging_IP_Address.Test
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void DefangIPaddrTestMethod()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual("1[.]1[.]1[.]1", Solution.DefangIPaddr("1.1.1.1"));
            Assert.AreEqual("255[.]255[.]255[.]0", Solution.DefangIPaddr("255.255.255.0"));
        }
    }
}
