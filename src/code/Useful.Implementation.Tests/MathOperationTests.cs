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
        public void Test1()
        {

            var mathOperations = new MathOperations();
            var sum = mathOperations.Add(2, 2);

            Assert.That(sum, Is.EqualTo(4));
        }
    }
}