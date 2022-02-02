using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;
using System.Threading;

namespace Feb2Prj
{

    class Features
    {
        public static int year = 2017;
        static void Main()
        {
            try
            {
                int[] a = new int[5];
                a[1] = 20;
                int number = 0;
                int answer = 5 / number;
            }
            catch(Exception e) when (e.GetType().ToString()=="System.IndexOutOfRangeException")
            {
                SomeotherFunction();
            }
            catch(DivideByZeroException) when (DateTime.Now.DayOfWeek!=DayOfWeek.Monday)
            {
                Console.WriteLine("Sorry, Today is not Monday");
            }
            catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Welcome.. You can register today");
            }
            //literal improvements (_)
            var lit1 = 476_487_586_98; //digit seperators
            var lit2 = 0xa3_7e;   //hexadecimal literal
            var lit3 = 1100_1011_0100_1001;
            Console.WriteLine($"lit1 :{lit1}, lit2: {lit2}, lit3: {lit3}");
            Console.WriteLine(LeapYear());
            Console.WriteLine("enter  the side of square :");
            int s = ToInt32(ReadLine());
            int square = AreaofSquare(s);
            Thread.Sleep(2000);
            Write($"Area of Square is {square}");
            Console.Read();
        }
        static void SomeotherFunction()
        {
            Console.WriteLine("This is a new Task...");
        }

        //normal way of writing a function
        //public static string LeapYear()
        //{
        //    return "\n Is" + year + " a leap Year -" + DateTime.IsLeapYear(year);
        //}
        //with expression bodied member
        public static string LeapYear() => $"\n  Is {year}  a leap year - " + DateTime.IsLeapYear(year);
        public static int AreaofSquare(int side) => side * side;
    }
}
