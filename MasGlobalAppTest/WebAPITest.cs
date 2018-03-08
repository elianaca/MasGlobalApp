using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasGlobalApp.WebAPI.Controllers;
using System.Web.Http.Results;

namespace MasGlobalAppTest
{
    [TestClass]
    public class WebAPITest
    {
        EmployeeController controller = new EmployeeController();

        [TestMethod]
        public void TestGetAll()
        {
            var employees = controller.GetAllEployees();
            Assert.IsNotNull(employees);
        }

        [TestMethod]
        public void TestGetEmployeeSuccess()
        {
            var employee = controller.GetEmployee(1);
            Assert.IsNotNull(employee);
        }

        [TestMethod]
        public void TestGetEmployeeFail()
        {
            var employee = controller.GetEmployee(3);
            Assert.IsInstanceOfType(employee, typeof(NotFoundResult));
        }
    }
}
