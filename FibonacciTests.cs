using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [DataRow(6, 8)]
        [DataRow(9, 34)]
        [DataRow(15, 610)]
        [DataRow(20, 6765)]
        [DataRow(30, 832040)]
        [DataRow(40, 102334155)]
        public void TestFibonacciIteratively(int nth, int expected)
        {
            // Arrange
            var sut = new Fibonacci();

            // Act
            var actual = sut.ExecuteIteratively(nth);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [DataRow(6, 8)]
        [DataRow(9, 34)]
        [DataRow(15, 610)]
        [DataRow(20, 6765)]
        [DataRow(30, 832040)]
        [DataRow(40, 102334155)]
        public void TestFibonacciRecursively(int nth, int expected)
        {
            // Arrange
            var sut = new Fibonacci();

            // Act
            var actual = sut.ExecuteRecursively(nth);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [DataRow(6, 8)]
        [DataRow(9, 34)]
        [DataRow(15, 610)]
        [DataRow(20, 6765)]
        [DataRow(30, 832040)]
        [DataRow(40, 102334155)]
        public void TestFibonacciRecursivelyWithMemoisation(int nth, int expected)
        {
            // Arrange
            var sut = new Fibonacci();

            // Act
            var actual = sut.ExecuteRecursivelyWithMemoisation(nth);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
