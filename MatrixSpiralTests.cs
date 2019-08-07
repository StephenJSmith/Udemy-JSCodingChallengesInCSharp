using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class MatrixSpiralTests
    {
        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void TestMatrixSpirals(int input)
        {
            // Arrange
            var sut = new MatrixSpiral();

            // Act
            var actual = sut.Execute(input);

            // Assert
        }
    }
}
