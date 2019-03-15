using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.BL.DomainEntities
{
    public class Employee
    {
        public decimal Salary { get; } = 0;
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
    }
}
