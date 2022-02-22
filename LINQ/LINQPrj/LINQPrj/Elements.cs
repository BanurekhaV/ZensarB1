using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrj
{
    class Elements
    {
        static void get_ElementAt()
        {
            string[] fruits = { "Apple", "Oranges", "Mangoes", "Bananas", "Grape" };
                   //              0        1          2          3          4
            var res = fruits.ElementAt(1);
            Console.WriteLine(res);
            var res1 = fruits.ElementAtOrDefault(10);
            if (res1 == null)
            {
                Console.WriteLine("There is no element at the given index");
            }
            else
            Console.WriteLine(res1);

            //to find first element in the collection
            var result = fruits.First();
            Console.WriteLine($"first element is {result}");
            string[] cities= { };

            var city = cities.FirstOrDefault();
            if(city==null)
            Console.WriteLine("No elements");

            //Lambda with extension method first
            var length = fruits.FirstOrDefault(f => f.Length == 6);
            Console.WriteLine(" First Element with length 6 is :{0}",length);

        }
        static void Single_Check()
        {
            //single or default
            string[] str1 = { "Joshitha" };
            string[] str2 = { "Nandhini", "Janani", "Bandini" };
            string[] str3 = { };
            var res = str1.SingleOrDefault();
            Console.WriteLine(res);
            try
            {
                var res1 = str2.SingleOrDefault();
                Console.WriteLine(res1);
            }
            catch(Exception e)
            {
                Console.WriteLine("MoreElements in the collection");
            }
            var res2 = str3.SingleOrDefault();
            if(res2 ==null)
            Console.WriteLine("No elements");
        }

        static void Main()
        {
             get_ElementAt();
           // Single_Check();
            Console.Read();

        }
    }
}
