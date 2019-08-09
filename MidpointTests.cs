using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class MidpointTests
    {
        [TestMethod]
        public void OddNumberNodesList_ReturnsMiddleNode()
        {
            // Arrange
            var sut = new Midpoint<string>();
            var list = new LinkedList<string>();
            var expectedNodeData = "C";
            list.InsertFirst("A");
            list.InsertLast("B");
            list.InsertLast(expectedNodeData);
            list.InsertLast("D");
            list.InsertLast("E");

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.AreEqual(expectedNodeData, actual.Data);
        }
        [TestMethod]
        public void EvenNumberNodesList_ReturnsLastNodeInFirstHalf()
        {
            // Arrange
            var sut = new Midpoint<string>();
            var list = new LinkedList<string>();
            var expectedNodeData = "C";
            list.InsertFirst("A");
            list.InsertLast("B");
            list.InsertLast(expectedNodeData);
            list.InsertLast("D");
            list.InsertLast("E");
            list.InsertLast("F");

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.AreEqual(expectedNodeData, actual.Data);
        }

        [TestMethod]
        public void HeadNodeOnly_ReturnsHeadNode()
        {
            // Arrange
            var expectedNodeData = "A";
            var list = new LinkedList<string>();
            list.InsertFirst(expectedNodeData);
            var sut = new Midpoint<string>();

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.AreEqual(expectedNodeData, actual.Data);
        }

        [TestMethod]
        public void NoHeadNode_ReturnsNull()
        {
            // Arrange
            var sut = new Midpoint<string>();
            var list = new LinkedList<string>();

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsNull(actual);
        }
    }
}
