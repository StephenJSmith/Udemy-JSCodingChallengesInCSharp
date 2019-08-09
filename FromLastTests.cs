using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class FromLastTests
    {
        [TestMethod]
        public void ReturnNElementsFromEnd()
        {
            // Arrange
            var sut = new FromLast<string>();
            var list = new LinkedList<string>();
            list.InsertFirst("A");
            var expectedData = "B";
            list.InsertLast(expectedData);
            list.InsertLast("C");
            list.InsertLast("D");
            list.InsertLast("E");

            // Act
            var node = sut.Execute(list, 3);

            // Assert
            Assert.AreEqual(expectedData, node.Data);
        }

        [TestMethod]
        public void NOutOfRange_ReturnsNull()
        {
            // Arrange
            var sut = new FromLast<string>();
            var list = new LinkedList<string>();
            list.InsertLast("A");
            list.InsertLast("B");

            // Act
            var node = sut.Execute(list, 2);

            // Assert
            Assert.IsNull(node);
        }

    }
}
