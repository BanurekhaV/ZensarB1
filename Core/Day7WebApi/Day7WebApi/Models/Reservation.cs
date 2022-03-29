using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day7WebApi.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
    }
}
