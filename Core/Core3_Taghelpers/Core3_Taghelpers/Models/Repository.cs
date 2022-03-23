using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core3_Taghelpers.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product newProduct);
    }
    public class ProductRepository :IRepository
    {
        private List<Product> products = new List<Product>
        {
            new Product{Name="Mens Watches", Price=250.50f,Quantity=100},
             new Product{Name="Ladies Watches", Price=350.50f,Quantity=200},
              new Product{Name="Shoes", Price=100.50f,Quantity=300},
               new Product{Name="Shirts", Price=125.50f,Quantity=400},
        };
        public IEnumerable<Product> Products => products;

        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }
    }
}
