using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class DL : IProduct
    {
        public string InsertData()
        {
            string str = "Dependency Injection -- Injected";
            Console.WriteLine(str);
            return str;
        }
    }
}
