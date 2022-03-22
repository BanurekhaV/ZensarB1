using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrj2.Models
{
    public class StudentRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> stdlist = new List<Student>()
           {
               new Student{StdId=1, StdName="Shivam",Gender="Male",Discipline="CSC"},
               new Student{StdId=2, StdName="Rishab",Gender="Male",Discipline="ECE"},
               new Student{StdId=3, StdName="Srikanth",Gender="Male",Discipline="IT"},
               new Student{StdId=4, StdName="Arbaz",Gender="Male",Discipline="CSC"},
               new Student{StdId=5, StdName="Namitha",Gender="Female",Discipline="EEE"},
           };
            return stdlist;
           }
        public Student GetStudentById(int id)
        {
            Student s = new Student()
            {
                StdId = id,
                StdName = "Nikitha",
                Gender = "Female",
                Discipline = "IT"
            };

            return s;
        }
    }
}
