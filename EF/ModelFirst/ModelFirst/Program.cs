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

            var newprod = (from product in mc.Products
                           where product.Prodname == "Markers"
                           select product).SingleOrDefault();
            newprod.Prodname = "Pencil Pouch";
            mc.SaveChanges();

            var delprod = (from d in mc.Products
                           where d.Pid == 2
                           select d).Single();
            mc.Products.Remove(delprod);
            mc.SaveChanges();

            foreach(var s in prods)
            {
                Console.WriteLine($"{s.Pid},{s.Prodname},{s.Price},{s.QOH}");
            }
            Console.Read();
        }
    }
}
