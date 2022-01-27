using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    interface IName
    {
        string Name { get; set; } //property decl.
    }

    class Employee : IName
    {
        string empname;
        //  public string Name { get; set; } //automatic implementation of the Name property
        public string Name
        {
            get { return empname; }
            set { empname = value; }
        }
    }

    class Company : IName
    {
        public int age { get; set; } //automatic implementation
        private string _companyname { get; set; }
        public string Name    //manual implementation of the Name property
        {
            get { return _companyname; }
            set { _companyname = value; }
        }
        //public int CompanyAge
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

    }
    class Properties_in_Interfaces
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Shivam";
            IName c = new Company();
            c.Name = "Zensar";
            Console.WriteLine($"Employee Named :{e.Name} works for {c.Name}");
            Company company = new Company();
            company.Name = "Zensar";
            company.age = 20;
            Console.WriteLine($"Company {company.Name} is{company.age} years old");
            Console.WriteLine($"Employee Named :{e.Name} works for {c.Name} which is {company.age}years Old");
            Console.Read();
        }
    }
}
