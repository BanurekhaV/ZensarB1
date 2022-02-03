using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Tuples
    {
        static void Main()
        {
            //before c#7.0
            //var values = new List<double>() { 10, 20, 30, 40, 50 };
            //Tuple<int, double> t = Calculate(values);
            //Console.WriteLine($"There are {t.Item1} values and their sum is {t.Item2}");

            //after c# 7.0 1st option
            //var values = new List<double>() { 10, 20, 30, 40, 50 };
            //var result = Calculate(values);
            //Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");

            //2nd option
            //var values = new List<double>() { 10, 20, 30, 40, 50 };
            //var (countresult, sumresult) = Calculate(values);
            //Console.WriteLine($"There are {countresult} values and the sum is {sumresult}");
            TestEnumerators();
            Console.Read();
        }

        //before C#7.0
        //static Tuple<int,double>Calculate(IEnumerable<double>values)
        //after c#7.0
        static(int count,double sum)Calculate(IEnumerable<double>values)
        {
            int count = 0;
            double sum = 0.0;
            foreach(var v in values)
            {
                count++;
                sum += v;
            }
           
            //befor C#7.0
            //create an object of tuple class by calling the satic create method
            //Tuple<int, double> t = Tuple.Create(count, sum);
            ////return the tuple object
            //return t;
            //after C# 7.0
            return (count, sum);
        }

        public static void TestEnumerators()
        {
            List<string> Months = new List<string>();
            Months.Add("Jan");
            Months.Add("Feb");
            Months.Add("Mar");
            Months.Add("Apr");
            IEnumerable<string> imonth = (IEnumerable<string>)Months;
            foreach(string s in imonth)
            {
                Console.WriteLine(s);
            }
            IEnumerator<string> istr = Months.GetEnumerator(); //to convert list into IEnemerator type
            //to retrieve all the values you need to invoke the MoveNext()
            while(istr.MoveNext())
            {
                Console.WriteLine(istr.Current);
            }

        }
    }
}
