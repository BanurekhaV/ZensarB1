using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Feb2Prj
{
    class Student
    {
       public int StudentId;
      public string StudntName;
    }
    class Initializers
    {
        static void Main()
        {
            List<Student> studlist = new List<Student>()
            {
                new Student(){StudentId=1,StudntName="Rajesh"},
                new Student(){StudentId=2,StudntName="Rakesh"},
                new Student(){StudentId=3,StudntName="Sukesh"},
                null
            };
            var div = Divide(10, 2);
            IEnumerable<string> names = from s in studlist
                                        where s.StudntName.StartsWith("R")
                                        select s.StudntName;

            foreach(var std in names)
            {
                Console.WriteLine(std);
            }
            Console.Read();
        }
        public static double Divide(int x, int y)
        {
            return y != 0 ? x / y : throw new DivideByZeroException();
        }
    }
}
