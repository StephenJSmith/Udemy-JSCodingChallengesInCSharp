using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class TwoSidedStepsPyramidsTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void PrintPyramidsIteratively(int totalRows)
        {
            // Arrange
            var sut = new TwoSidedStepsPyramids();

            // Act
            sut.ExecuteIteratively(totalRows);

            // Asert
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void PrintPyramidsRecursiveRows(int totalRows)
        {
            // Arrange
            var sut = new TwoSidedStepsPyramids();

            // Act
            sut.ExecuteRecursiveRows(totalRows);

            // Asert
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void PrintPyramidsRecursiveRowsAndCols(int totalRows)
        {
            // Arrange
            var sut = new TwoSidedStepsPyramids();

            // Act
            sut.ExecuteRecursiveRowsAndCols(totalRows);

            // Asert
        }
    }
}
