using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class MaxCharsTests
    {
        [TestMethod]
        [DataRow("abccccdba", 'c')]
        [DataRow("apple 12311132", '1')]
        [DataRow("Hello there!", 'e')]
        public void MaxCharsUsingCharMap(string input, char expected)
        {
            // Arrange
            var sut = new MaxChars();

            // Act
            var actual = sut.Execute(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
