using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class IntegerReversalTests
    {
        [TestMethod]
        [DataRow(15, 51)]
        [DataRow(981, 189)]
        [DataRow(500, 5)]
        [DataRow(-15, -51)]
        [DataRow(-90, -9)]
        public void ReverseIntegerWithSign(int input, int expected)
        {
            // Arrange
            var sut = new IntegerReversal();

            // Act
            var actual = sut.Execute(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
