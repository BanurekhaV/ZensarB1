using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Ref_locals_Ref_returns
    {
        static void Main()
        {
            int num1 = 5;
           ref int num2 =  ref num1; //we are giving the reference of num1 to the local variable num2
            num2 = 8;
            Console.WriteLine($"Local variable : {nameof(num1)} , {nameof(num2)} after the change:{num1} and {num2}");
            num1 = 10;
            Console.WriteLine($"Local variable : {nameof(num1)} , {nameof(num2)} after the change:{num1} and {num2}");

            //getting the reference from ref  returns
            char[] array = { 's', 'a', 'n', 't', 'o', 's', 'h' };
            Console.WriteLine($"Before ref returns: {new string(array)}");
            ref char cref = ref RefReturns.FindCharRef('a', array);
            cref = 'e'; //replacing the value from a to e in that location which is pointed by cref
            Console.WriteLine($"After ref returns: {new string(array)}");
            Console.Read();
        }
    }

    class RefReturns
    {
        public static ref char FindCharRef(char c, char[] carray)
        {
            for(int i=0;i<carray.Length;i++)
            {
                if(carray[i]==c)
                {
                    return ref carray[i]; //returns the storage location and not the value of the matched character
                }
            }
            throw new IndexOutOfRangeException(c + " " + "notfound");
        }
    }
}
