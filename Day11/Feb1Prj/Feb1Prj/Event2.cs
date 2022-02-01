using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{
    public delegate string Mydel(string str);

    class Event2
    {
        event Mydel MyEvent;

        public Event2()
        {
            this.MyEvent += new Mydel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome :" + username;
        }

        public string Message(string s)
        {
            return s;
        }

        static void Main()
        {
            Event2 eventobj = new Event2();
            string result = eventobj.MyEvent("To Events in C#");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
