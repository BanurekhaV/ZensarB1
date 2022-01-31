using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorExtension
{
    //1. class has to be public static
    public static class SubtractClass
    {
        //2. create an object of the first library class - a concept of extension that is being passed 
        //to the new method as a first argument
        public static int SubtractNum(this Calculatorclass cobj, int x, int y)
        {
            return x - y;
        }

        public static int Multiply(this Calculatorclass cobj, int x, int y)
        {
            return x * y;
        }
    }

    //public class SubtractClass
    //{
    //    Calculatorclass cobj = new Calculatorclass();

    //    public int SubtractNum(int x, int y)
    //    {

    //        return x - y;
    //    }
    //}
}
