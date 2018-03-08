using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasGlobalApp.DataAccess;

namespace MasGlobalAppTest
{
    [TestClass]
    public class DataAccessTest
    {
        APIRepository repository = new APIRepository();

        [TestMethod]
        public void TestGetEmployees()
        {
            var employees = repository.GetEmployees();

            Assert.IsTrue(employees.Count > 0);
        }
    }
}
