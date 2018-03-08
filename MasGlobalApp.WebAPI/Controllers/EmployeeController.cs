using MasGlobalApp.BL;
using MasGlobalApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MasGlobalApp.WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeesFactory factory = new EmployeesFactory();
        APIRepository repository = new APIRepository();

        /// <summary>
        /// Gets all eployees.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAllEployees()
        {
            var employees = repository.GetEmployees();
            List<BaseEmployee> baseEmployees = new List<BaseEmployee>();

            foreach (var employee in employees)
            {
                baseEmployees.Add(factory.GetEmployee(employee));
            }

            return Ok(baseEmployees);
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = repository.GetEmployees().FirstOrDefault((p) => p.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(factory.GetEmployee(employee));
        }
    }
}
