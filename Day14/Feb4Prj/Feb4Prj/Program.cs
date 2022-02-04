using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    public class SmartPhone : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsFlagship { get; set; }
        
        public int CompareTo(object obj)
         {
            if (obj == null) return 1;
            SmartPhone nextSmartPhone = obj as SmartPhone;
            if(nextSmartPhone!=null)
            {
                return this.Price.CompareTo(nextSmartPhone.Price);
            }
            else
            {
                throw new ArgumentException("Object does not have a proper price");
            }
         }

        public override string ToString()
        {
            return "Name : " + Name + "||" + "Price :" + Price + "||" + "IsFlagShipPhone :" + IsFlagship; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<SmartPhone> smartPhones = new List<SmartPhone>()
            {
                new SmartPhone()
            {
                Name = "One Plus 8",
                Price = 55000,
                IsFlagship = true
            },
            new SmartPhone()
            {
                Name = "IPhone 13",
                Price = 100000,
                IsFlagship = true
            },
            new SmartPhone()
            {
                Name = "Samsung Ultra",
                Price = 70000,
                IsFlagship = false
            },
            };
            smartPhones.Sort();
            foreach(var item in smartPhones)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Read();
        }
    }
}
