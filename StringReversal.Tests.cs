using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class StringReversalTests
    {
        [TestMethod]
        [DataRow("apple", "elppa")]
        [DataRow("hello", "olleh")]
        [DataRow("Greetings!", "!sgniteerG")]
        public void ReverseStringUsingStringBuilder(string input, string expected)
        {
            // Arrange
            var sut = new StringReversal();

            // Act
            var actual = sut.ExecuteWithStringBuilder(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("apple", "elppa")]
        [DataRow("hello", "olleh")]
        [DataRow("Greetings!", "!sgniteerG")]
        public void ReverseStringUsingArrayReverse(string input, string expected)
        {
            // Arrange
            var sut = new StringReversal();

            // Act
            var actual = sut.ExecuteReverseArray(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("apple", "elppa")]
        [DataRow("hello", "olleh")]
        [DataRow("Greetings!", "!sgniteerG")]
        public void ReverseStringUsingEnumeratedArray(string input, string expected)
        {
            // Arrange
            var sut = new StringReversal();

            // Act
            var actual = sut.ExecuteWithEnumeratedArray(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
