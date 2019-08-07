using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void Push_AddObject_ObjectIsAddedToStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void Push_ArgIsNull_ThrowsArgumentNullException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException );
        }
 
        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }
        
        [Test]
        public void Count_StackContent_ReturnCount()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }


        [Test]
        public void Pop_RemoveObject_RemoveLastObject()
        {
        }
        
//        [Test]
//        public void Pop_RemoveObject_RemoveLastObject()
//        {
//        }

        [Test]
        public void Peek_ViewObject_ExpectedBehavior()
        {
        }
    }
}