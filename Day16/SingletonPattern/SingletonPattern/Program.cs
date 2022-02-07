using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingleTonObject
    {
        //static object of the class is getting created through a private constructor
        private static SingleTonObject sobj = new SingleTonObject();

        //private constructor
        private SingleTonObject() { }

        //Method to retrieve the one and only object
        public static SingleTonObject getObject()
        {
            return sobj;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World of SingleTon!!..");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the Singleton object through the method of the class and not constructor
            SingleTonObject s = SingleTonObject.getObject();
            //call the other public method
            s.ShowMessage();
            Console.Read();
        }
    }
}
