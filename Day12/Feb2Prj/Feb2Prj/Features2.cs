using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Prj
{
    class Features2
    {
        //local functions (inner functions)
        static void Main()
        {
            int Sum(int x, int y)
            {
                return x + y;
            }
            int a = 10, b = 5;
            int sum = Sum(a, b);
            int diff = Difference(a, b);
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The Difference  of {a} and {b} is {diff}");

            int Difference(int x, int y)
            {
                return x - y;
            }
            
            Console.WriteLine("Tap any key to exit..");
            int d = Difference(10, 2);
            Console.WriteLine(d);
            Console.Read();

        }
    }

    
}
