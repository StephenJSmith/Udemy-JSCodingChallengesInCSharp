using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class CircularListTests
    {
        [TestMethod]
        public void CircularLinkedList_ReturnsTrue()
        {
            // Arrange
            var sut = new CircularList<string>();
            var list = new LinkedList<string>();

            var a = new Node<string>("A");
            var b = new Node<string>("B");
            var c = new Node<string>("C");
            var d = new Node<string>("D");

            list.Head = a;
            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = b;

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CircularLinkedListAtHead_ReturnsTrue()
        {
            // Arrange
            var sut = new CircularList<string>();
            var list = new LinkedList<string>();

            var a = new Node<string>("A");
            var b = new Node<string>("B");
            var c = new Node<string>("C");
            var d = new Node<string>("D");

            list.Head = a;
            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = a;

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CircularLinkedListTwoNodes_ReturnsTrue()
        {
            // Arrange
            var sut = new CircularList<string>();
            var list = new LinkedList<string>();

            var a = new Node<string>("A");
            var b = new Node<string>("B");

            list.Head = a;
            a.Next = b;
            b.Next = a;

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void NonCircularLinkedList_NoNodes_ReturnsFalse()
        {
            // Arrange
            var sut = new CircularList<string>();
            var list = new LinkedList<string>();

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void NonCircularLinkedList_HeadOnly_ReturnsFalse()
        {
            // Arrange
            var sut = new CircularList<string>();
            var list = new LinkedList<string>();
            list.InsertFirst("A");

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void NonCircularLinkedList_ReturnsFalse()
        {
            // Arrange
            var sut = new CircularList<string>();
            var list = new LinkedList<string>();
            list.InsertFirst("A");
            list.InsertLast("B");
            list.InsertLast("C");

            // Act
            var actual = sut.Execute(list);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
