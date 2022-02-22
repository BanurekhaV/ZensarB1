using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODay3Prj
{
    class Student
    {
       public  int stdid;
       public  string stdname;
        public int age;
    }
    class LinqtoObjects
    {
        static void Main()
        {
            //1. Linq to objects
            string[] names = { "Sampath", "VenkatRao", "Varma", "Swathi", "SivaSai" };
            //linq query - query syntax
            var myquery = from nm in names
                          where nm.Contains('t')
                          select nm.ToString();

            //query execution
            foreach(var item in myquery)
            {
                Console.WriteLine(item +" ");
            }

            //example for method Syntax
            List<Student> studlist = new List<Student>()
            {
                new Student(){stdid=1,stdname="Ravi Kumar",age=21},
                new Student(){stdid=2,stdname="Ashok",age=13},
                new Student(){stdid=3,stdname="Rakesh",age=18},
                new Student(){stdid=4,stdname="Sruthi",age=15},
                new Student(){stdid=5,stdname="Suresh",age=20},
            };

            var teenagestudents = studlist.Where(s => s.age > 12 && s.age < 20).ToList<Student>();
            Console.WriteLine("========Greater than 13 and less than 20===========");
            foreach(var t in teenagestudents)
            {
                Console.WriteLine($"{t.stdid},{t.stdname},{t.age}");
            }

            IEnumerable<Student> queryoutput = from s in studlist
                                               orderby s.stdname descending
                                               select s;
            Console.WriteLine("========Sorted Student List===================");

            foreach(var item in queryoutput)
            {
                Console.WriteLine(item.stdname +" "+ item.age);
            }

            IEnumerable<string> studentnames = from s in studlist
                                               where s.stdname.StartsWith("R")
                                               select s.stdname;

            Console.WriteLine("=========Names with R=========");

            foreach(string s in studentnames)
            {
                Console.WriteLine(s);
            }

            Console.Read();
        }
    }
}
