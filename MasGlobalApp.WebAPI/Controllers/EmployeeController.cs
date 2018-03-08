using MasGlobalApp.BL;
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

        /// <summary>
        /// Gets all eployees.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAllEployees()
        {
            return Ok(factory.GetEmployees());
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = factory.GetEmployees().FirstOrDefault((p) => p.Employee.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
