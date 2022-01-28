using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28Prj
{
    class StaticEg
    {
        //let us declare and initialize the static Data member
        private static int Myval1 = 5;

        public static int Value
        {
            get { return Myval1; }
        }
        
        public static void PrintVal()
        {
            Console.WriteLine("StaticEg Class.val1" + " "+ Myval1);
        }
    }
    class StaticEg2
    {
        private static int val1=30;

        //static constructor

        static StaticEg2()
        {
            if(StaticEg2.val1 < 10)
            {
                val1 = 25;
            }
            else
            {
                val1 = 100;
            }
            Console.WriteLine("Static Constructor for class StaticEg2 called...");
        }

        public static void Print()
        {
            Console.WriteLine("StaticEg2 Class.val1" + " " + val1);
        }

        static void Main()
        {
            StaticEg.PrintVal();
            Print();
            Console.Read();
        }
    }
}
