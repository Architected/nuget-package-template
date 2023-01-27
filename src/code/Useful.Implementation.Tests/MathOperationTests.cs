using System.Diagnostics.CodeAnalysis;

namespace Useful.Implementation.Tests
{
    [ExcludeFromCodeCoverage]
    public class MathOperationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {

            var mathOperations = new MathOperations();
            var sum = mathOperations.Add(2, 2);

            Assert.That(sum, Is.EqualTo(4));
        }

        [Test]
        public void TestSubtract()
        {

            var mathOperations = new MathOperations();
            var sum = mathOperations.Subtract(4, 2);

            Assert.That(sum, Is.EqualTo(2));
        }
    }
}