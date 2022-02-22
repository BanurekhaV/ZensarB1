using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrj
{
    class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }
    }
    class Lambda
    {
        //Examples for Lambda
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };

            Console.WriteLine("Numbers in the List");
            foreach(int n in numbers)
            { 
                Console.WriteLine(n); 
            }
            //use lamda expr. to calculate the suqare of the numbers in the list
            var squares = numbers.Select(x => x * x);

            Console.WriteLine("=======Sqaures of the numbers==============");
            foreach(int n in squares)
            {
                Console.WriteLine(n);
            }


            //lambda to find all numbers divisible by 3
            List<int> divby3 = numbers.FindAll(x => (x % 3) == 0);

            Console.WriteLine("======Divisible by 3-====");
            foreach (int n in divby3)
            {
                Console.WriteLine(n);
            }

            //lambda in userdefined datatypes

            List<Employee1> emplist = new List<Employee1>()
            {
                new Employee1{ID=101, Name="Sudheer",Sal=35789},
                new Employee1{ID=103, Name="Sumit",Sal=34566},
                new Employee1{ID=102, Name="Ashok",Sal=356754},
            };
            Employee1 empl = emplist.Find(emp => emp.ID == 102);
            Console.WriteLine("=========A singleEmployee with 102 as ID===");
            Console.WriteLine($"ID:{empl.ID}, Name:{empl.Name}, Salary:{empl.Sal}");

            //to sort the employee details
            var empsorted = emplist.OrderBy(x => x.Name);

            Console.WriteLine("=====Sorted Employees on name=====");
            foreach(var item in empsorted)
            {

                Console.WriteLine($"{item.Name}");
            }

            Console.Read();
        }
    }
}
