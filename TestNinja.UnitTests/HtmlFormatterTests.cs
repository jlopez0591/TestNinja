using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        private HtmlFormatter _formatter { get; set; }
        //SetUp
        [SetUp]
        public void SetUp()
        {
            _formatter = new HtmlFormatter();
        }
        //TearDown
        public void TearDown() { }

        [Test]
        [TestCase("abc")]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement(string txt)
        {
            string result = _formatter.FormatAsBold(txt);
            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // More general
            //Assert.That(result, Does.StartWith("<strong>"));
            //Assert.That(result, Does.Contain(txt));
            //Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
