using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{

    class Function_Arguments
    {

        //default Parameters
        public static void Studetails(string fname, string lname, int age=20,string branch="CSC")
        {
            Console.WriteLine($"Firstname : {fname}");
            Console.WriteLine($"Lastname : {lname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Stream : {branch}");
        }
        //named Parameters
        public static void Stud_dtls(string fname, string lname,int age,string branch)
        {
            Console.WriteLine($"{fname}, {lname},{age},{branch}");
        }

        static void Main()
        {
            Studetails("Gulshan", "Kumar");
            Studetails("Menaka", "Gandhi", 56);
            Studetails("Rohan", "Joshi", 45, "IT");
            //calling function with named parameters
            Stud_dtls(age: 35, fname: "Raj", lname: "Bahadur", branch: "CSC");
            Console.Read();
        }
    }
}
