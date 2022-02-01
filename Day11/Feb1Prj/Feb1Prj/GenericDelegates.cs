using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{
    //generic delegate
    public delegate T Trans<T>(T arg);

    class Utility
    {
        public static void Transform<T>(T[] values,Trans<T> t )
        {
            for(int i=0; i<values.Length; i++)
            {
                values[i] = t(values[i]); //invoking a delegate
            }
        }
    }
    class GenericDelegates
    {
        static void Main()
        {
            int[] val = new int[] { 4, 5, 6 };
            Utility.Transform(val, Square);
            foreach(var i in val)
            {
                Console.Write(i + " ");
            }
            string[] str = { "Red", "Blue", "Green" };
            Utility.Transform(str, Showstring);
            foreach (var x in str)
            {
                Console.Write(x + " ");
            }

            Console.Read();
        }

        static string Showstring(string s)
        {
            return "Color"+ " " +s;
        }
        static int Square(int x)
        {
            return x * x;
        }
    }
}
