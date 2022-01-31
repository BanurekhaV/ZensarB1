using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorExtension2
{
    public static class Class1
    {
        public static string Message(this Calculatorclass cobj, string str)
        { 
            return "hello" + " " + str;
        }
        public static int Divide(this Calculatorclass cobj, int x, int y)
        {
            return x / y;
        }
    }
}
