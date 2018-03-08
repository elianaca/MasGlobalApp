using MasGlobalApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalApp.BL
{
    public class MonthlySalaryEmployee : BaseEmployee
    {
        private Employee _employee = new Employee();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlySalaryEmployee"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public MonthlySalaryEmployee(Employee employee): base(employee)
        {
            _employee = employee;
            AnnualSalary = CalculateAnnualSalary();
        }

        /// <summary>
        /// Calculates the annual salary.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override double CalculateAnnualSalary()
        {
            return _employee.MonthlySalary * 12;
        }
    }
}
