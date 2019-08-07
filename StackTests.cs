using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Pop_LastInFirstOut()
        {
            // Arrange
            var expected = 3;
            var sut = new Stack<int>();
            sut.Push(1);
            sut.Push(2);
            sut.Push(expected);
            var expectedCount = sut.Count - 1;

            // Act
            var actual = sut.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, sut.Count);
        }

        [TestMethod]
        public void Peek_LastInWithoutPoppingIt()
        {
            // Arrange
            var expected = 3;
            var sut = new Stack<int>();
            sut.Push(1);
            sut.Push(2);
            sut.Push(expected);
            var expectedCount = sut.Count;

            // Act
            var actual = sut.Peek();

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, sut.Count);
        }

        [TestMethod]
        public void CanPeek_IfStackContainsItems()
        {
            // Arrange
            var sut = new Stack<int>();
            sut.Push(1);
            var expected = true;

            // Act
            var actual = sut.CanPeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotCanPeek_IfStackContainsNoItems()
        {
            // Arrange
            var sut = new Stack<int>();
            var expected = false;

            // Act
            var actual = sut.CanPeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
