using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{
    public class EventTest
    {
        int value;
        public delegate void numbermanipulator(int x);
        //Event declaration and association with the delegate
        public event numbermanipulator changenum;

        public  void onNumChanged(int x)
        {
            Console.WriteLine($"Event Raised and value from {value} is changed to {x}");
        }

        public EventTest(int n)
        {
            this.changenum += new numbermanipulator(this.onNumChanged); //association of the delegate with the event
            setvalue(n);
        }

        public void setvalue(int n) //responsible for raising an event
        {
            if(value!=n)
            {
               // value = n;
                onNumChanged(n);
            }
            else
            { 
                Console.WriteLine("No changes in the value and hence no notification");
            }
        }
    }
    class Events
    {
        static void Main()
        {
            EventTest t = new EventTest(5);
            t.setvalue(15);
            t.setvalue(0);
            t.setvalue(20);
            Console.Read();
        }
    }
}
