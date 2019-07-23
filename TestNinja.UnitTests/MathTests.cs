using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// Summary description for MathTests
    /// </summary>
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //SetUp
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        //TearDown

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = _math.Add(2, 1);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
