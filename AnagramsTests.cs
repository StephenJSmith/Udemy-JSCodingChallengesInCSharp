using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        [DataRow("rail safety", "fairy tales", true)]
        [DataRow("RAIL! SAFETY!", "fairy tales", true)]
        [DataRow("Hi There", "Bye there", false)]
        [DataRow("hello", "hellos", false)]
        public void TestAnagramsUsingDictionaries(string input1, string input2, bool expected)
        {
            // Arrange
            var sut = new Anagrams();

            // Act
            var actual = sut.IsAnagramsUsingDictionaries(input1, input2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("rail safety", "fairy tales", true)]
        [DataRow("RAIL! SAFETY!", "fairy tales", true)]
        [DataRow("Hi There", "Bye there", false)]
        [DataRow("hello", "hellos", false)]
        public void TestAnagramsSortingStrings(string input1, string input2, bool expected)
        {
            // Arrange
            var sut = new Anagrams();

            // Act
            var actual = sut.IsAnagramsSortingStrings(input1, input2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
