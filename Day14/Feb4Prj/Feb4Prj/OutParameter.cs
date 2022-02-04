using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class OutParameter
    {
        static void Main()
        {

            //out parameters before C# 7.0
            //string ename, gender, department;
            //long salary;
            //GetEmp(out ename, out gender, out salary, out department);
            //Console.WriteLine($"{ ename}, { gender},{ salary},{ department}");

            //with C# 7.0 rewrite the above code as below
            //GetEmp(out string ename, out string gender, out long salary, out string department);
            //Console.WriteLine($"{ ename}, { gender},{ salary},{ department}");
            //if we want to ignore output parameter
            GetEmp(out var ename, out var gender, out var salary, out _);
            Console.WriteLine($"{ ename}, { gender},{ salary}");
            Console.Read();
        }
        static void GetEmp(out string ename,out string gender, out long salary,out string department)
        {
            ename = "Harini";
            gender = "Female";
            salary = 45000;
            department = "HR";
        }
    }
}
