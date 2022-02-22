using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrj
{
    class LinqToSql
    {
        static ZensarDataContext zd = new ZensarDataContext();
        static NorthwindContext nw = new NorthwindContext();
        static void Main()
        {
            
            var emp = zd.Employees.ToList();
            Console.WriteLine("Employee List");
            foreach(var e in emp)
            {
                Console.WriteLine($"{e.EmpId},{e.EmpName},{e.Email},{e.Gender},{e.Salary},{e.Dept}");
            }
            
            var emps = from e in zd.Employees
                       orderby e.EmpName
                       select e;
            Console.WriteLine("==================");
            Console.WriteLine("Sorted Employee List");
            foreach (var e in emps)
            {
                Console.WriteLine($"{e.EmpId},{e.EmpName},{e.Email},{e.Gender},{e.Salary},{e.Dept}");
            }
            var northwind = nw.Region1s.ToList();
            Console.WriteLine( "===================");
            foreach(var r in northwind)
            {
                Console.WriteLine(r.RegionID + " " +r.RegionDescription);
            }
            Console.Read();
        }

        static void Insert()
        {
            
        }
    }
}
