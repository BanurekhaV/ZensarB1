using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Feb2Prj
{
    class Program
    {

        static void Method1()
        {
            for(int i=0; i<=5;i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if(i==3)
                {
                    Console.WriteLine("Started Database Operation ...");
                    //make the thread sleep for sometime..say 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Database Operations Completed.....");
                }
            }
        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            //by default threads dont have names, if we want we can assign explicitly
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread Name :" + " " + t.Name);
            Console.WriteLine("Current Excecuting Thread Name :"+ " " + Thread.CurrentThread.Name);
            Method1();
            Method2();
            Method3();
            Console.Read();
        }
    }
}
