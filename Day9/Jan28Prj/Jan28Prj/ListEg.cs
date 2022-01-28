using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28Prj
{
    class ListEg
    {
        public static void Main()
        {
            //generic way of declaring objects
            List<int> mylist = new List<int>();
            mylist.Add(45);
            mylist.Add(20);
            mylist.Add(12);

            foreach(int x in mylist)
            {
                Console.WriteLine(x);
            }
            //hashtables of collections are equal to Dictionary of Generics
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Red");
            dict.Add(2, "Blue");
            dict.Add(5, "Green");
            dict.Add(3, "Yellow");
            dict.Add(9, "Orange");
            dict.Add(4, "White");

            foreach(int a in dict.Keys)
            {
                Console.WriteLine(a);
            }
            foreach(string s in dict.Values)
            {
                Console.WriteLine(s);
            }

            //inorder to get both keys and values, use keyvaluepair
            foreach(KeyValuePair<int,string>item in dict)
            {
                Console.Write(item.Key);
                Console.Write(item.Value);
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
