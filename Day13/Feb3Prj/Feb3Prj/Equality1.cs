using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class class1 { }
    class class2 { }
    class Equality1
    {
        public static void Test(Object obj)
        {
            class1 a;
            class2 b;
            if(obj is class1)
            {
                Console.WriteLine("Obj is Class1");
                a = (class1)obj;
            }
            else if(obj is class2)
            {
                Console.WriteLine("Obj is Class2");
                b = (class2)obj;
            }
            else if(obj is List<int>)
            {
                Console.WriteLine("It was a string");
            }
            else
            {
                Console.WriteLine("Obj is neither Class1 nor Class2");
            }
        }
        static void Main()
        {
            //class1 c1 = new class1();
            //class2 c2 = new class2();
            //Test(c1);
            //Test(c2);
            //Test("Passing string data ");
            //string s = "hi";
            //Test(s);
            //List<int> l = new List<int>();
            //Test(l);
            Object[] myobjects = new object[6];
            myobjects[0] = new class1();
            myobjects[1] = new class2();
            myobjects[2] = "Data String";
            myobjects[3] = 32;
            myobjects[4] = null;
            for(int i=0; i<myobjects.Length;++i)
            {
                string s = myobjects[i] as string;
                Console.Write("{0}:", i);
                if(s!=null)
                    Console.WriteLine("'" + s + "'");
                else
                    Console.WriteLine("Not a string");

            }

            Console.Read();
        }
    }
}
