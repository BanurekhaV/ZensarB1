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

        public Employee DeleteEmployee(int Id)
        {
            Employee e = db.Employees.Find(Id);
            if(e != null)
            {
                db.Employees.Remove(e);
                db.SaveChanges();
            }
            return e;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            return db.Employees.Find(Id);
        }

        public Employee UpdateEmployee(Employee empchanges)
        {
            
            var employee = db.Employees.Attach(empchanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return empchanges;

            //db.Employees.Attach(empchanges);
            //var entry = db.Entry(empchanges);
            //entry.Property(e => e.Name).IsModified = true;
            //entry.Property(e => e.Gender).IsModified = true;
            //entry.Property(e => e.Salary).IsModified = true;
            // other changed properties
           // entry.State = EntityState.Modified;
           // db.SaveChanges();
            //return empchanges;

        }
    }
}
