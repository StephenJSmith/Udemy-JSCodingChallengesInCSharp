using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void NodeConstructor_TakesData()
        {
            // Arrange
            var expected = "Hi";

            // Act
            var sut = new Node<string>(expected);

            // Assert
            var actual = sut.Data;
            Assert.AreEqual(expected, actual);
            Assert.IsNull(sut.Next);
        }

        [TestMethod]
        public void NodeConstructor_TakesDataAndNext()
        {
            // Arrange
            var expectedNext = new Node<string>("Initial");
            var expectedData = "Hi";

            // Act
            var sut = new Node<string>(expectedData, expectedNext);

            // Assert
            Assert.AreEqual(expectedData, sut.Data);
            Assert.AreEqual(expectedNext, sut.Next);
        }

        [TestMethod]
        public void InsertFirst_NoHead_NodeCreatedAsHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            var initialData = "Alpha";

            // Act
            sut.InsertFirst(initialData);

            // Assert
            Assert.AreEqual(initialData, sut.Head.Data);
        }

        [TestMethod]
        public void InsertFirst_ExistingHead_NewNodePrependsExistingHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            var newHeadData = "Alpha";
            var initialHeadData = "Beta";
            sut.InsertFirst(initialHeadData);

            // Act
            sut.InsertFirst(newHeadData);

            // Assert
            Assert.AreEqual(newHeadData, sut.Head.Data);
            Assert.AreEqual(initialHeadData, sut.Head.Next.Data);
        }

        [TestMethod]
        public void Size_NoHead_Zero()
        {
            // Arrange
            var expected = 0;
            var sut = new LinkedList<string>();

            // Act
            var actual = sut.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_MultipleItemsInserted_NumberInserted()
        {
            // Arrange
            var expected = 3;
            var sut = new LinkedList<int>();
            sut.InsertFirst(1);
            sut.InsertFirst(2);
            sut.InsertFirst(3);

            // Act
            var actual = sut.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFirst_NoHead_Null()
        {
            // Arrange
            var sut= new LinkedList<string>();
            
            // Act
            var actual = sut.GetFirst();

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetFirst_HasHead_HeadNode()
        {
            // Arrange
            var expected = "Alpha";
            var sut= new LinkedList<string>();
            sut.InsertFirst(expected);

            // Act
            var actual = sut.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual.Data);
        }

        [TestMethod]
        public void GetLast_NoHead_Null()
        {
            // Arrange
            var sut = new LinkedList<string>();

            // Act
            var actual = sut.GetLast();

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetLast_HasHeadAndNodes_LastNode()
        {
            // Arrange
            var expected = "Omega";
            var sut = new LinkedList<string>();
            sut.InsertFirst(expected);
            sut.InsertFirst("Epsilon");
            sut.InsertFirst("Alpha");

            // Act
            var actual = sut.GetLast();

            // Assert
            Assert.AreEqual(expected, actual.Data);
        }

        [TestMethod]
        public void Clear_EmptiesList()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("alpha");
            sut.InsertFirst("beta");
            sut.InsertFirst("gamma");

            // Act
            sut.Clear();

            // Assert
            Assert.AreEqual(0, sut.Size());
        }

        [TestMethod]
        public void RemoveFirst_NoHead()
        {
            // Arrange
            var sut = new LinkedList<string>();

            // Act
            sut.RemoveFirst();

            // Assert
            Assert.IsNull(sut.Head);
            Assert.AreEqual(0, sut.Size());
        }

        [TestMethod]
        public void RemoveFirst_SizeIsOne_RemovesHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("alpha");

            // Act
            sut.RemoveFirst();

            // Assert
            Assert.IsNull(sut.Head);
            Assert.AreEqual(0, sut.Size());
        }

        [TestMethod]
        public void RemoveFirst_SizeIsMoreThanOne_HeadPointsToSecondNode()
        {
            // Arrange
            var expectedData = "alpha";
            var sut = new LinkedList<string>();
            sut.InsertFirst(expectedData);
            sut.InsertFirst("beta");
            var expectedCount = sut.Size() - 1;

            // Act
            sut.RemoveFirst();

            // Assert
            Assert.AreEqual(expectedData, sut.Head.Data);
            Assert.AreEqual(expectedCount, sut.Size());
        }

        [TestMethod]
        public void RemoveLast_NoHead_NoAction()
        {
            // Arrange
            var sut = new LinkedList<string>();

            // Act
            sut.RemoveLast();

            // Assert
            Assert.IsNull(sut.Head);
            Assert.AreEqual(0, sut.Size());
        }

        [TestMethod]
        public void RemoveLast_SingleNode_HeadIsNull()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");

            // Act
            sut.RemoveLast();

            // Assert
            Assert.IsNull(sut.Head);
            Assert.AreEqual(0, sut.Size());
        }

        [TestMethod]
        public void RemoveLast_MultipleNodes_PenultimateIsNewTail()
        {
            // Arrange
            var expectedData = "Beta";
            var sut = new LinkedList<string>();
            sut.InsertFirst("Gamma");
            sut.InsertFirst(expectedData);
            sut.InsertFirst("Alpha");

            // Act
            sut.RemoveLast();

            // Assert
            Assert.AreEqual(expectedData, sut.GetLast().Data);
        }

        [TestMethod]
        public void InsertLast_NoHead_CreatesHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            var expectedData = "Alpha";

            // Act
            sut.InsertLast(expectedData);

            // Assert
            Assert.AreEqual(expectedData, sut.Head.Data);
            Assert.AreEqual(1, sut.Size());
        }

        [TestMethod]
        public void InsertLast_OnlyHead_HeadReferencesNewNode()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");
            var expectedData = "Beta";

            // Act
            sut.InsertLast(expectedData);

            // Assert
            Assert.AreEqual(expectedData, sut.GetLast().Data);
            Assert.AreEqual(2, sut.Size());
        }

        [TestMethod]
        public void InsertLast_MultipleNodes_NewNodeAsTail()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");
            sut.InsertLast("Beta");
            sut.InsertLast("Delta");
            var expectedData = "Gamma";
            var expectedCount = sut.Size() + 1;

            // Act
            sut.InsertLast(expectedData);

            // Assert
            Assert.AreEqual(expectedData, sut.GetLast().Data);
            Assert.AreEqual(expectedCount, sut.Size());
        }

        [TestMethod]
        public void GetAt_NoNodes_ReturnsNull()
        {
            // Arrange
            var sut = new LinkedList<string>();

            // Act
            var actual = sut.GetAt(2);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetAt_HeadOnly_ReturnsHead()
        {
            // Arrange
            var expectedData = "Alpha";
            var sut = new LinkedList<string>();
            sut.InsertFirst(expectedData);

            // Act
            var actual = sut.GetAt(0);

            // Assert
            Assert.AreEqual(expectedData, actual.Data);
        }

        [TestMethod]
        public void GetAt_MultipleNodes_ReturnsCorrectNode()
        {
            // Arrange
            var expected0Data = "Alpha";
            var expected1Data = "Beta";
            var expected2Data = "Gamma";
            var sut = new LinkedList<string>();
            sut.InsertFirst(expected0Data);
            sut.InsertLast(expected1Data);
            sut.InsertLast(expected2Data);

            // Act
            var actual0 = sut.GetAt(0);
            var actual1 = sut.GetAt(1);
            var actual2 = sut.GetAt(2);

            // Assert
            Assert.AreEqual(expected0Data, actual0.Data);
            Assert.AreEqual(expected1Data, actual1.Data);
            Assert.AreEqual(expected2Data, actual2.Data);
        }

        [TestMethod]
        public void GetAt_IndexOutOfRange_ReturnsNull()
        {
            // Arrange
            var expected0 = "Alpha";
            var expected1 = "Beta";
            var expected2 = "Gamma";
            var sut = new LinkedList<string>();
            sut.InsertFirst(expected0);
            sut.InsertLast(expected1);
            sut.InsertLast(expected2);

            // Act
            var actual = sut.GetAt(3);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void RemoveAt_HeadOnly_RemovesHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");

            // Act
            sut.RemoveAt(0);

            // Assert
            Assert.IsNull(sut.Head);
            Assert.AreEqual(0, sut.Size());
        }

        [TestMethod]
        public void RemoveAt_NoNodes_NotThrowExeception()
        {
            // Arrange
            var sut = new LinkedList<string>();

            // Act
            sut.RemoveAt(1);

            // Assert
            Assert.IsNull(sut.Head);
        }

        [TestMethod]
        public void RemoveAt_RemoveAtHead_ReplaceHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");
            var expectedData = "Beta";
            sut.InsertLast(expectedData);
            sut.InsertLast("Gamma");
            var expectedCount = sut.Size() - 1;

            // Act
            sut.RemoveAt(0);

            // Assert
            Assert.AreEqual(expectedData, sut.Head.Data);
            Assert.AreEqual(expectedCount, sut.Size());
        }

        [TestMethod]
        public void RemoveAt_RemoveInList_ItemRemoved()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");
            sut.InsertLast("Beta");
            sut.InsertLast("Gamma");
            var expectedData = "Delta";
            sut.InsertLast(expectedData);
            sut.InsertLast("Epsilon");
            var expectedSize = sut.Size() - 1;

            // Act
            sut.RemoveAt(2);

            // Assert
            Assert.AreEqual(expectedData, sut.GetAt(2).Data);
            Assert.AreEqual(expectedSize, sut.Size());
        }

        [TestMethod]
        public void RemoveAt_RemoveLastNode_ItemRemoved()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("Alpha");
            sut.InsertLast("Beta");
            sut.InsertLast("Gamma");
            var expectedData = "Delta";
            sut.InsertLast(expectedData);
            sut.InsertLast("Epsilon");
            var expectedSize = sut.Size() - 1;

            // Act
            sut.RemoveAt(4);

            // Assert
            Assert.AreEqual(expectedData, sut.GetLast().Data);
            Assert.AreEqual(expectedSize, sut.Size());
        }

        [TestMethod]
        public void InsertAt_NoHeadNode_InsertAsHead()
        {
            // Arrange
            var sut = new LinkedList<string>();
            var expectedData = "Alpha";

            // Act
            sut.InsertAt(expectedData, 0);
            
            // Assert
            Assert.AreEqual(expectedData, sut.Head.Data);
            Assert.AreEqual(1, sut.Size());
        }

        [TestMethod]
        public void InsertAt_IndexInRange_InsertInListAtIndex()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("A");
            sut.InsertLast("B");
            sut.InsertLast("C");
            var expectedNextData = "E";
            sut.InsertLast(expectedNextData);
            var insertedData = "D";
            var expectedSize = sut.Size() + 1;

            // Act
            sut.InsertAt(insertedData, 3);

            // Assert
            var newNode = sut.GetAt(3);
            Assert.AreEqual(insertedData, newNode.Data);
            Assert.AreEqual(expectedNextData, newNode.Next.Data);
            Assert.AreEqual(expectedSize, sut.Size());
        }

        [TestMethod]
        public void InsertAt_IndexIsLastIndex_InsertAtEnd()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("A");
            sut.InsertLast("B");
            sut.InsertLast("C");
            sut.InsertLast("D");
            var expectedData = "E";
            var expectedSize = sut.Size() + 1;

            // Act
            sut.InsertAt(expectedData, 4);

            // Assert
            Assert.AreEqual(expectedData, sut.GetLast().Data);
            Assert.IsNull(sut.GetLast().Next);
            Assert.AreEqual(expectedSize, sut.Size());
        }

        [TestMethod]
        public void InsertAt_IndexOutOfRange_InsertAtEnd()
        {
            // Arrange
            var sut = new LinkedList<string>();
            sut.InsertFirst("A");
            sut.InsertLast("B");
            sut.InsertLast("C");
            sut.InsertLast("D");
            var expectedData = "E";
            var expectedSize = sut.Size() + 1;

            // Act
            sut.InsertAt(expectedData, 5);

            // Assert
            Assert.AreEqual(expectedData, sut.GetLast().Data);
            Assert.IsNull(sut.GetLast().Next);
            Assert.AreEqual(expectedSize, sut.Size());
        }
    }
}
