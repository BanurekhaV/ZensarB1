using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Day4EFCodeFirstPrj.Models
{
    public class CarContext : DbContext
    {
        public CarContext():base("name=Motors")
        {

        }

        public DbSet<Car> cars { get; set; }
    }
}