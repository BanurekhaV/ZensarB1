using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    class Employees
    {
        //decl properties
        int ID;
        string Name;
        double Salary;
        //constructor to initialize properties
        public Employees(int ID,string Name,double Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
        }

        //defining indexers

        public object this[int index]
        {
            //get accessors to return values
            get
            {
                if (index == 0)
                    return Name;
                else if (index == 1)
                    return ID;
                else if (index == 2)
                    return Salary;
                else
                    return null;
            }
            //set accessors to assign values
            set
            {
                if (index == 1)
                    ID = Convert.ToInt32(value);
                else if (index == 0)
                    Name = value.ToString();
                else if (index == 2)
                    Salary = Convert.ToDouble(value);
                
            }
        }
        //overloaded indexer
        public object this[string s]
        {
            get
            {
                if (s == "eid")
                    return ID;
                else if (s == "ename")
                    return Name;
                else if (s == "sal")
                    return Salary;
                else
                    return null;
            }
            set
            {
                if (s == "eid")
                    ID = Convert.ToInt32(value);
                else if (s == "ename")
                    Name = value.ToString();
                else if (s == "sal")
                    Salary = Convert.ToDouble(value);
            }
        }
    }
    class IndexersEg1
    {
        static void Main()
        {
            //create an instance of Employees
            Employees emp = new Employees(101,"Geethanjali",10000.50);
            Console.WriteLine("EmployeeId=" + " "+ emp[1]);
            Console.WriteLine("Name=" + " " +emp[0]);
            Console.WriteLine("Salary=" + " " + emp[2]);
            emp[0] = "Hemanth";
            emp[1] = 125;
            emp[2] = 11000;
            Console.WriteLine("===========After modifications============");
            Console.WriteLine("EmployeeId=" + " " + emp[1]);
            Console.WriteLine("Name=" + " " + emp[0]);
            Console.WriteLine("Salary=" + " " + emp[2]);

            Console.WriteLine("==============using Overloaded Indexers==========");
            Employees emp2 = new Employees(201,"Praveen",12000);
           
            Console.WriteLine("EmployeeId=" + " " + emp2["eid"]);
            Console.WriteLine("Name=" + " " + emp2["ename"]);
            Console.WriteLine("Salary=" + " " + emp2["sal"]);
            emp2["eid"] = 202;
            emp2["ename"] = "Prajwal";
            emp2["sal"] = 13000;
            Console.WriteLine("===========After modifications============");
            Console.WriteLine("EmployeeId=" + " " + emp2["eid"]);
            Console.WriteLine("Name=" + " " + emp2["ename"]);
            Console.WriteLine("Salary=" + " " + emp2["sal"]);
            Console.Read();
        }
    }
}
