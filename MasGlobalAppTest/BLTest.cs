using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasGlobalApp.DataAccess;
using MasGlobalApp.BL;
using System.Linq;

namespace MasGlobalAppTest
{
    [TestClass]
    public class BLTest
    {
        APIRepository repository = new APIRepository();
        EmployeesFactory factory = new EmployeesFactory();

        [TestMethod]
        public void TestHourlyAnnualSalary()
        {
            var employees = repository.GetEmployees();
            var employee = employees.Where(x => x.ContractTypeName.Equals("HourlySalaryEmployee", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            HourlySalaryEmployee salaryEmployee = new HourlySalaryEmployee(employee);
            Assert.IsTrue(salaryEmployee != null && salaryEmployee.AnnualSalary > 0);
        }

        [TestMethod]
        public void TestMonthlyAnnualSalary()
        {
            var employees = repository.GetEmployees();
            var employee = employees.Where(x => x.ContractTypeName.Equals("MonthlySalaryEmployee", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            MonthlySalaryEmployee salaryEmployee = new MonthlySalaryEmployee(employee);
            Assert.IsTrue(salaryEmployee != null && salaryEmployee.AnnualSalary > 0);
        }        
    }
}
