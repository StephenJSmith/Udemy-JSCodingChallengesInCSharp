using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class PalindromesTests
    {
        [TestMethod]
        [DataRow("abba", true)]
        [DataRow("abcdefg", false)]
        [DataRow("kayak", true)]
        public void IsPalindromeReversingString(string input, bool expected)
        {
            // Arrange
            var sut = new Palindromes();

            // Act
            var actual = sut.IsPalindromeComparingReversedString(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abba", true)]
        [DataRow("abcdefg", false)]
        [DataRow("kayak", true)]
        public void IsPalindromeUsingOppositeIndices(string input, bool expected)
        {
            // Arrange
            var sut = new Palindromes();

            // Act
            var actual = sut.IsPalindromeUsingOppositeIndices(input);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("abba", true)]
        [DataRow("abcdefg", false)]
        [DataRow("kayak", true)]
        public void IsPalindromeUsingRecursion(string input, bool expected)
        {
            // Arrange
            var sut = new Palindromes();

            // Act
            var actual = sut.IsPalindromeUsingRecursion(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
