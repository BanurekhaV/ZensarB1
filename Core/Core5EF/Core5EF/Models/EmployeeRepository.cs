using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5EF.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext db;
        public EmployeeRepository(EmployeeDBContext context)
        {
            db = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            return db.Employees.Find(Id);
        }
    }
}
