using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class FindTheVowelsTests
    {
        [TestMethod]
        [DataRow("Hi There!", 3)]
        [DataRow("Why do you ask?", 4)]
        [DataRow("Why?", 0)]
        [DataRow("Uppercase", 4)]

        public void TestEnumeratingInput(string input, int expected)
        {
            // Arrange
            var sut = new FindTheVowels();

            // Act
            var actual = sut.ExecuteEnumerating(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Hi There!", 3)]
        [DataRow("Why do you ask?", 4)]
        [DataRow("Why?", 0)]
        [DataRow("Uppercase", 4)]

        public void TestUsingLinq(string input, int expected)
        {
            // Arrange
            var sut = new FindTheVowels();

            // Act
            var actual = sut.ExecuteLinq(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Hi There!", 3)]
        [DataRow("Why do you ask?", 4)]
        [DataRow("Why?", 0)]
        [DataRow("Uppercase", 4)]

        public void TestUsingRegEx(string input, int expected)
        {
            // Arrange
            var sut = new FindTheVowels();

            // Act
            var actual = sut.ExecuteRegEx(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
