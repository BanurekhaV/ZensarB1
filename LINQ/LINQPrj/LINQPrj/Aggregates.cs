using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrj
{
    class Aggregates
    {
        //to multiply the set of elements in a collection
        public static void Aggregate1()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };// { 2,3,4,5} {6,4,5} {24,5}{120}

            var res = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine($"Aggregated Multiplication is {res}");
        }

        //example of aggregates with initial seed to summ up all elements values 

        public static void aggreagates_withSeed()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var res = numbers.Aggregate(10, (a, b) => a + b);
            Console.WriteLine($"Aggregated Sum with initial seed value is {res}");
        }

        public static void Average()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var res = numbers.Average();
            Console.WriteLine($"Average of the numbers:{res}");
        }

        //string to list convertion
        public static void StringToList()
        {
            string[] empnames = { "John", "Bob", "Robert", "Steve" };
            List<string> res = empnames.ToList();

            Console.WriteLine(string.Format("name is of type :{0}", empnames.GetType().Name));
            Console.WriteLine(string.Format("res is of type :{0}", res.GetType().Name));
        }
    }

    class Tester
    {
        static void Main()
        {
            Aggregates.Aggregate1();
            Aggregates.aggreagates_withSeed();
            Aggregates.StringToList();
            Console.Read();
        }
    }
}
