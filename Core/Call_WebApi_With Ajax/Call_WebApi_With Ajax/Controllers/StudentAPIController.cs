using Call_WebApi_With_Ajax.Models.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Call_WebApi_With_Ajax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PersonalDetails> GetAllStudents()
        {
            List<PersonalDetails> studlist = new List<PersonalDetails>
            {
                new PersonalDetails
                {
                    RollNo="R001",
                    Name="Banurekha",
                    Address="Chennai",
                    Phone="12345678",
                    AdmissionDate=DateTime.Now
                },
                new PersonalDetails
                {
                    RollNo="R002",
                    Name="Monisha",
                    Address="Hyderabad",
                    Phone="14677878",
                    AdmissionDate=DateTime.Now
                },
                new PersonalDetails
                {
                    RollNo="R003",
                    Name="Ramesh",
                    Address="Bangalore",
                    Phone="1999999978",
                    AdmissionDate=DateTime.Now
                },
            };
            return studlist;
        }
    }
}
