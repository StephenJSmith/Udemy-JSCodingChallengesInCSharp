using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(5)]
        [DataRow(15)]
        public void OutputFizzBuzz(int input)
        {
            // Arrange
            var sut = new FizzBuzz();

            // Act
            sut.Execute(input);

            // Assert
        }
    }
}
