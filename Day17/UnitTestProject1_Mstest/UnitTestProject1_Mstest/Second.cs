using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTestProject1_Mstest
{
    [TestClass]
   public class Second
    {
        [TestMethod]
       
        public void secondclassMethod()
        {
            Trace.WriteLine("Method 1 of second class");
        }
    }
}
