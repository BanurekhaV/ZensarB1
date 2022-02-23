using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
       static Model1Container mc = new Model1Container();
        static void Main(string[] args)
        {
            var prods = from p in mc.Products
                        orderby p.Price descending
                        select p;



            foreach(var s in prods)
            {
                Console.WriteLine($"{s.Pid},{s.Prodname},{s.Price},{s.QOH}");
            }
            Console.Read();
        }
    }
}
