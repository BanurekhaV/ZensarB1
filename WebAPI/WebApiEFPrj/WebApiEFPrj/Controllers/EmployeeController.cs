using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEFPrj.Models;

namespace WebApiEFPrj.Controllers
{
    public class EmployeeController : ApiController
    {
        ZensarDBEntities zdb = new ZensarDBEntities();

        //Get
        public HttpResponseMessage Get()
        {
            var emp = zdb.Employees.ToList();
            if(emp.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, emp);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No Data Found");
            }
        }

        //post

        public IHttpActionResult PostNewEmployee(Employee employee)
        {
            if(!ModelState.IsValid)
            
                return BadRequest("Validations Failed");
            zdb.Employees.Add(new Employee()
            {
                EmpId = employee.EmpId,
                EmpName = employee.EmpName,
                Email = employee.Email,
                Salary = employee.Salary,
                Gender = employee.Gender,
                Dept = employee.Dept
            });
            zdb.SaveChanges();
            return Ok();
            
        }
    }
}
