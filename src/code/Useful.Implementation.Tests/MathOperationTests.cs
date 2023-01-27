namespace Useful.Implementation.Tests
{
    public class MathOperationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var mathOperations = new MathOperations();
            var sum = mathOperations.Add(2, 2);

            Assert.That(sum, Is.EqualTo(4));
        }
    }
}