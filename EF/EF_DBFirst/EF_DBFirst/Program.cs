using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_DBFirst
{
    
    class Program
    {
        static NorthwindEntities ne = new NorthwindEntities();
        static Region region = new Region();
        static void Main(string[] args)
        {
            Console.WriteLine("1. Insert into Region");
            Console.WriteLine("2. Display Region ");
            string choice = Console.ReadLine();
            if(choice=="1")
            {
                Console.WriteLine("Enter Region ID:");
                region.RegionID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Description:");
                region.RegionDescription = Console.ReadLine();
                ne.Regions.Add(region);
                ne.SaveChanges();
                Console.WriteLine("Successfully added");
            }
            if(choice=="2")
            {
                var reg = from r in ne.Regions
                          select r;

                foreach(var item in reg)
                {
                    Console.WriteLine(item.RegionID + " "+ item.RegionDescription);
                }
            }
            Console.Read();
        }
    }
}
