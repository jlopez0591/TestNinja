using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator { get; set; }

        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        [TestCase(50, 0, TestName = "NoDemeritPoints")] // Below speed limit
        [TestCase(70, 1, TestName = "ReturnDemeritPoints")] // Above speed limit
        [TestCase(75, 2, TestName = "ReturnDemeritPoints")] // Above speed limit
        public void CalculateDemeritPoints_ValidCases_(int speed, int expectedResult)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(-1, TestName = "ThrowArgumentOutOfReachException")] // Negative Speed
        [TestCase(301, TestName = "ThrowArgumentOutOfReachException")] // Above Max Speed
        public void CalculateDemeritPoints_Exceptions_(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}