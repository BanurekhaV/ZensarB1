using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Feb2Prj
{
    class ThreadstartEg
    {
        static void Main()
        {
            //1. creating threadstart delegate instance by passing the method name as a parameter to its constructor
            ThreadStart tobj = new ThreadStart(DisplayNumbers);
            //2. passing the threadstatr delegate instance to thread
            Thread t1 = new Thread(tobj);
            t1.Start();

            //Step 1 and 2 can be rewitten as below
            Thread th1 = new Thread(new ThreadStart(DisplayNumbers));

            //The above can also be written as below
            Thread th2 = new Thread(delegate () { DisplayNumbers(); });

            //The above can also be written using Lambda Expression
            Thread th3 = new Thread(() => { DisplayNumbers(); });
            //or
            Thread th4 = new Thread(() => DisplayNumbers());
            //The DisplayNumbers function can be written as an Anoymous Method
            Thread thread = new Thread(() => { for (int i = 0; i <= 5; i++) { Console.WriteLine(i); } });

            Console.Read();
        }

        static void DisplayNumbers()
        {
            for(int i=0; i<=5;i++)
            {
                Console.WriteLine("Method 1:" + " "+ i);
            }
        }
    }
}
