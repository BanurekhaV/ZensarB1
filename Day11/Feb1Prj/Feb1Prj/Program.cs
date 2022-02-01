using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{
    class Program
    {
        
        delegate void Print(int val);
            
        static void Main(string[] args)
        {
            //Print p1 = new Print(Sample);
            //p1(200);
            //p1(300);
            //p1(400);
            //Anonymous Methods
            Print p = delegate (int x) { Console.WriteLine("Inside Anonymous method.Value{0}", x+5); };
            p(100);                    
          //  p(500);

            //Anonymous method can access variables defined in an outer function
            int z = 10;
            Print print = delegate (int y)
            {
                y += z; Console.WriteLine("Anonymous Method accessing outside" +
                "variable {0}", y);
            };
            print(10); //invoking the anonymous method thru the delegate object
            
            Console.Read();
        }

        public static void Sample(int c)
        {
            
            c = c + 100;
            Console.WriteLine("Inside NormalMethod");
            Console.WriteLine(c);
            Print p = delegate (int x) { Console.WriteLine("Inside Sample method.Value{0}", x*2); };
            p(100);
            //testfunc();

        }
        public static void testfunc()
        {
            Console.WriteLine("Inside Testing");
        }
    }
}
