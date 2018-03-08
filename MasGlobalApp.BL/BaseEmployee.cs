using MasGlobalApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalApp.BL
{
    public abstract class BaseEmployee
    {
        public Employee Employee { get; set; }
        public BaseEmployee(Employee employee)
        {
            Employee = employee;
        }
        public double AnnualSalary { get; set; }
        public abstract double CalculateAnnualSalary();
    }
}
