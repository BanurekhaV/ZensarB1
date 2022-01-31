using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    public delegate void Multidelegate();
    public delegate int multiretdelgate(int n);
    class MulticastDelegates
    {
        public static void Method1()
        {
            Console.WriteLine( "Method 1 Invoked");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2 Invoked");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 Invoked");
        }

        class TestMultiretdelegate
        {
            static int p=0;
            public int Square(int x)
            {
                p = x * x;
                return p;
            }

            public int Tripple(int q)
            {
                p = q * q * q;
                return p;
            }
        }

        static void Main()
        {
            //Multidelegate m1, m2, m3, m4;
            //m1 = new Multidelegate(Method1);
            //m2 = new Multidelegate(Method2);
            //m3 = new Multidelegate(Method3);
            //m4 = m1 + m2 + m3; //one way of multicasting
            //m4(); //invoking the delegate

            Multidelegate m1 = new Multidelegate(Method1);
            m1 += Method2;
            m1 += Method3;  //second way of multicasting
            m1();
            Console.WriteLine("==============");
            m1 -= Method2;  //removing one reference
            m1();
            Console.WriteLine("-------------Multicast with return type----------");
            TestMultiretdelegate tmd = new TestMultiretdelegate(); //class object created
            multiretdelgate mrdelegate = new multiretdelgate(tmd.Square);
            mrdelegate += tmd.Tripple;
            int retval = mrdelegate(5);
            Console.WriteLine(retval);
            Console.Read();
        }
    }
}
