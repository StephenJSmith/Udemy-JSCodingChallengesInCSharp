using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge
{
    [TestClass]
    public class WeaveTests
    {
        [TestMethod]
        public void CombineTwoQueuesOfEqualLength()
        {
            // Arrange
            var q1 = new Queue<int>();
            q1.Add(1);
            q1.Add(3);
            q1.Add(5);

            var q2 = new Queue<int>();
            q2.Add(2);
            q2.Add(4);
            q2.Add(6);

            var sut = new Weave<int>();

            // Act
            var weaved = sut.Execute(q1, q2);

            // Assert
            for (int expected = 1; expected <= 6; expected++)
            {
                Assert.AreEqual(expected, weaved.Remove());
            }
        }
    }
}
