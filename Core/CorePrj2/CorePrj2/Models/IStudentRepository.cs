using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrj2.Models
{
    //service interface
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int stdid);
    }
}
