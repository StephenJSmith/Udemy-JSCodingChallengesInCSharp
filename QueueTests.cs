using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void CanAddElementsToAQueue()
        {
            // Arrange
            var sut = new Queue<int>();
            var expectedCount = 1;

            // Act
            sut.Add(1);

            // Assert
            var actualCount = sut.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void CanRemoveElementFromQueue()
        {
            // Arrange
            var expected = 1;
            var sut = new Queue<int>();
            sut.Add(expected);

            // Act
            var actual = sut.Remove();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrderOfElementsMaintained()
        {
            // Arrange
            var sut = new Queue<int>();
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);

            // Act
            var item1 = sut.Remove();
            var item2 = sut.Remove();
            var item3 = sut.Remove();

            // Assert
            Assert.AreEqual(1, item1);
            Assert.AreEqual(2, item2);
            Assert.AreEqual(3, item3);
        }

        [TestMethod]
        public void PeekReturnsFirstValueWithoutRemoving()
        {
            // Arrange
            var sut = new Queue<int>();
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            var expected = 1;
            var expectedCount = sut.Count;

            // Act
            var actual = sut.Peek();

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, sut.Count);
        }

        [TestMethod]
        public void CannotPeekEmptyQueue()
        {
            // Arrange
            var sut = new Queue<int>();

            // Act
            var actual = sut.CanPeek();

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
