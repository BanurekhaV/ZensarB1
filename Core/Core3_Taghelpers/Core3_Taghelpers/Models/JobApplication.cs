using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core3_Taghelpers.Models
{
    public class JobApplication
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Experience { get; set; }
        public bool AcceptTerms { get; set; }
    }
}
