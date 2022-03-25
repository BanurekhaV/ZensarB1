using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5EF.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int Id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee empchanges);
        Employee DeleteEmployee(int Id);

    }
}
