using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        
        [SetUp]
        public void SetUp()
        {
            
        }
        
        [TearDown]
        public void TearDown(){}

        [Test]
        [TestCase(6, "Fizz", TestName = "InputIsDivisibleBy3Only_ReturnFizz")]
        [TestCase(10, "Buzz", TestName = "InputIsDivisibleBy5Only_ReturnBuzz")]
        [TestCase(15, "FizzBuzz", TestName = "InputIsDivisibleBy3And5_ReturnFizzBuzz")]
        [TestCase(4, "4", TestName = "InputIsNotDivisibleBy3Or5_ReturnInput")]
        public void GetOutput_(int number, string expected)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}