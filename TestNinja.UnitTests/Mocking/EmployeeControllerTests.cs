using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        private Mock<IEmployeeStorage> _storage;
        private EmployeeController controller;

        [SetUp]
        public void SetUp()
        {
            _storage = new Mock<IEmployeeStorage>();
            controller = new EmployeeController(_storage.Object);
        }

        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            controller.DeleteEmployee(1);
            _storage.Verify(s => s.DeleteEmployee(1));
        }

        //[Test]
        //public void DeleteEmployee_WhenCalled_ReturnRedirect()
        //{
        //    var result = controller.DeleteEmployee(1);
        //}
    }
}
