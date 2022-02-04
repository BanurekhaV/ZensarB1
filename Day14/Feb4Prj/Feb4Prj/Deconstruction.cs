using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Deconstruction
    {
        static (string,double,string,string)GetEmpDetails(long eid)
        {
            string Ename = "Namitha";
            double Salary = 25000;
            string Gender = "Female";
            string Dept = "IT";
            return (Ename, Salary, Gender, Dept);

        }
        static void Main()
        {
            //var Edetails = GetEmpDetails(1002);
            //var name = Edetails.Item1;
            //double Sal = Edetails.Item2;
            //var gender = Edetails.Item3;
            //var dept = Edetails.Item4;
            //Console.WriteLine($"The emp details are {name},{Sal},{gender},{dept}");

            // another way to deconstruct

            (string name, double sal, string gender, string dept) = GetEmpDetails(1002);

            //3rd way to deconstruct (use the variable names as that of the method that is returning the values
            var (Name, Salary, Gender, Dept) = GetEmpDetails(1002);

            //dictionary Initilalizers before C# 6.0
            Dictionary<int, string> emp = new Dictionary<int, string>()
            {
                {1,"Jyothi" },
                {2,"Akhilendra" },
                {3,"Hemanth" },
                {3,"Geetha" },
            };

            //with C# 6.0

            Dictionary<string, string> emp1 = new Dictionary<string, string>()
            {
                ["Sampath"] = "E001",
                ["Hanisha"] = "E005",

            };
            
            
            Console.Read();
        }
    }
}
