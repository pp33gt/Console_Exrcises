using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReg.BL.DomainEntities
{
    public class EmployeeRegister
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddEmployee(string firstName, string lastName, decimal salary)
        {
            AddEmployee(new Employee(firstName, lastName, salary));
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employees.ToList();
        }
    }
}
