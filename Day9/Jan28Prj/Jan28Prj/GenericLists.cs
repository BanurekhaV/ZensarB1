using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28Prj
{
    class Employee 
    {
        int Eid;
        string Ename;
        string Compname;
        float Salary;

        public Employee(int id, string ename, string cname,float sal)
        {
            Eid = id;
            Ename = ename;
            Compname = cname;
            Salary = sal;
        }

        public override string ToString()
        {
            return $"Employeeid: {Eid} with Name :{Ename} works with :{Compname} and earns Rs: {Salary}";
            //return string.Format("Empid: " + " " Eid + "Empname:" + " " + Ename);
        }
        //static void Main()
        //{
        //    List<Employee> emplist = new List<Employee>();
        //    emplist.Add(new Employee(101, "Nikitha", "Zensar", 12000));
        //    emplist.Add(new Employee(102, "SivaSai", "Zensar", 13000));
        //    emplist.Add(new Employee(103, "Venkat", "Zensar", 14000));

        //    foreach (Employee e in emplist)
        //    {
        //        Console.WriteLine($"Employee id {e.Eid}with Employee name {e.Ename} works with {e.Compname}");
        //    }
        //    Console.Read();
        //}
    }
    class GenericLists
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Nikitha", "Zensar", 12000));
            emplist.Add(new Employee(102, "SivaSai", "Zensar", 13000));
            emplist.Add(new Employee(103, "Venkat", "Zensar", 14000));
           

            foreach (var e in emplist)
            {
                // Console.WriteLine($"Employee id {e.Eid}with Employee name {e.Ename} works with {e.Compname}");
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }

    }
}
