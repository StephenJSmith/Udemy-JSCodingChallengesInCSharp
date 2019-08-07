using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class SentenceCapitalizationTests
    {
        [TestMethod]
        [DataRow("a short sentence", "A Short Sentence")]
        [DataRow("a lazy fox", "A Lazy Fox")]
        [DataRow("look, it is working", "Look, It Is Working")]
        [DataRow("AN UPPERCASE SENTENCE", "An Uppercase Sentence")]
        public void CapitalizeInputUsingSplitString(string input, string expected)
        {
            // Arrange
            var sut = new SentenceCapitalization();

            // Act
            var actual = sut.ExecuteWithSplitString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("a short sentence", "A Short Sentence")]
        [DataRow("a lazy fox", "A Lazy Fox")]
        [DataRow("look, it is working", "Look, It Is Working")]
        [DataRow("AN UPPERCASE SENTENCE", "An Uppercase Sentence")]
        public void CapitalizeInputEnumeratingArray(string input, string expected)
        {
            // Arrange
            var sut = new SentenceCapitalization();

            // Act
            var actual = sut.ExecuteEnumeratingString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
