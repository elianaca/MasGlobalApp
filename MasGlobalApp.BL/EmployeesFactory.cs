using MasGlobalApp.Common;
using MasGlobalApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalApp.BL
{
    public class EmployeesFactory
    {        
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public BaseEmployee GetEmployee(Employee employee)
        {
            if (employee.ContractTypeName.Equals("HourlySalaryEmployee", StringComparison.InvariantCultureIgnoreCase))
            {
                return new HourlySalaryEmployee(employee);
            }
            else
            {
                return new MonthlySalaryEmployee(employee);
            }
        }
    }
}
