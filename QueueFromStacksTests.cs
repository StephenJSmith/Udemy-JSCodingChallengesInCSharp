using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class QueueFromStacksTests
    {
        [TestMethod]
        public void OrderOfElementsMaintained()
        {
            // Arrange
            var sut = new QueueFromStacks<int>();

            // Act
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);

            // Assert
            for (var expected = 1; expected <= 3; expected++)
            {
                var actual = sut.Remove();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CanPeekWhenItemsInStack()
        {
            // Arrange
            var sut = new QueueFromStacks<int>();
            sut.Add(1);
            var expected = true;

            // Act
            var actual = sut.CanPeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanNotPeekWhenNoItemsInStack()
        {
            // Arrange
            var sut = new QueueFromStacks<int>();
            var expected = false;

            // Act
            var actual = sut.CanPeek();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PeekReturnsFirstEnteredWithoutPopping()
        {
            // Arrange
            var sut = new QueueFromStacks<int>();
            var expected = 1;
            sut.Add(expected);
            sut.Add(2);
            sut.Add(3);
            var expectedCount = sut.Count;

            // Act
            var actual = sut.Peek();

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, sut.Count);
        }

        [TestMethod]
        public void RemoveReturnsFirstEntered()
        {
            // Arrange
            var sut = new QueueFromStacks<int>();
            var expected = 1;
            sut.Add(expected);
            sut.Add(2);
            sut.Add(3);
            var expectedCount = sut.Count - 1;

            // Act
            var actual = sut.Remove();

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, sut.Count);
        }
    }
}
