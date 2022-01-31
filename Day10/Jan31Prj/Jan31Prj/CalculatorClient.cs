using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using CalculatorExtension;
using CalculatorExtension2;

namespace Jan31Prj
{
    class CalculatorClient
    {
        static void Main()
        {
            Calculatorclass cc = new Calculatorclass();
            Console.WriteLine(cc.Addnum(5, 6));
            Console.WriteLine(cc.SubtractNum(8, 5));
            Console.WriteLine(cc.Multiply(6,5));
            Console.WriteLine(cc.Message("Thakur"));
            Console.WriteLine(cc.Divide(10,2));
            Console.Read();
        }
    }
}
