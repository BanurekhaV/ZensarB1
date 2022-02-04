using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Iterators
    {
        public static IEnumerable<string> GetList()
        {
            List<string> mylst = new List<string>()
        {"Apples","Oranges","Grapes","Mangoes"};
            foreach (var items in mylst)
            {
                // Console.WriteLine(items);
                
                    yield return items;
                yield break;
            }
        }
        static void Main()
        {
            IEnumerable<string> elist = GetList(); ;

            foreach (var i in elist)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
