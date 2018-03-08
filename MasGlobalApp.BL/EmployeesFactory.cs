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
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        public List<BaseEmployee> GetEmployees()
        {
            try
            {
                APIRepository repository = new APIRepository();
                var employees = repository.GetEmployees();
                List<BaseEmployee> baseEmployees = new List<BaseEmployee>();

                foreach (var employee in employees)
                {
                    baseEmployees.Add(GetEmployee(employee));
                }

                return baseEmployees;
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        BaseEmployee GetEmployee(Employee employee)
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
