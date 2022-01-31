using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    class AnonymousTypes
    {
        static void Main()
        {
            
            var Mytype = new
            {
                data1 = "CSharp",
                data2 = 2,
                data3 = true
            };

            //lambda Expressions
            List<int> numbers = new List<int>() {16,23,12,19,42,28,57,7,9,30 };
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
            //using lambda finding the square of each element in the collection
                       //collection method input
            var square = numbers.Select(n => n * n);

            Console.WriteLine("Squares of the Collection..");
            foreach(var v in square)
            {
                Console.WriteLine("{0}",v);
            }

            // find all the numbers in the list that are divisible by 3
            List<int> divby3 = numbers.FindAll(m => (m % 3) == 0);
               foreach(var x in divby3)
            {
                Console.WriteLine("{0}",x);
            }
            Console.WriteLine(Mytype.ToString());
            Console.ReadLine();
        }
    }
}
