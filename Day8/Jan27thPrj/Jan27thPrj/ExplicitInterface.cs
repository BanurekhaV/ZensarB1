using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{

    interface Iinterface1
    {
        string Message(string s);
    }

    interface Iinterface2
    {
        string Message(string s);
    }
    class ExplicitInterface : Iinterface1,Iinterface2
    {
        string Iinterface1.Message(string s)//explicit implementation
        {
            return "Hello" +" "+ s;
        }

        public string Message(string s)//default implementation
        {
            return "Hi" + " "+ s;
        }

        static void Main()
        {
            //first way to invoke the methods of the class
            Iinterface1 ie1 = new ExplicitInterface();
            Iinterface2 ie2 = new ExplicitInterface();
            Console.WriteLine(ie1.Message("Swetha"));
            Console.WriteLine(ie2.Message("Krithika"));

            //second way of invoking the methods
            ExplicitInterface ei = new ExplicitInterface();
            Console.WriteLine(ei.Message("Zensar")); 
            Console.WriteLine(((Iinterface1)ei).Message("Swathi"));
            Console.WriteLine(((Iinterface2)ei).Message("Swathi"));
            Console.Read();
        }

    }
}
