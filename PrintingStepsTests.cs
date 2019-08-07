using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class PrintingStepsTests
    {
        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void PrintStepsLooping(int input)
        {
            // Arrange
            var sut = new PrintingSteps();

            // Act
            sut.ExecuteLooping(input);

            // Assert
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void PrintStepsRowsRecursively(int input)
        {
            // Arrange
            var sut = new PrintingSteps();

            // Act
            sut.ExecuteRowsRecursively(input);

            // Assert
        }


        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void PrintStepsRowsAndColsRecursively(int input)
        {
            // Arrange
            var sut = new PrintingSteps();

            // Act
            sut.ExecuteRowsAndColsRecursively(input);

            // Assert
        }
    }
}
