using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    //generic class
    class GenericProperty<T>
    {
        //generic member
        private T mydata;

        //genericproperty
        public T Data
        {
            get { return this.mydata; }
            set { this.mydata = value; }
        }
        //generic method
        public void Display<T>(string msg, T val)
        {
            Console.WriteLine("{0} : {1}", msg, val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //instance of string type
            GenericProperty<string> stringgeneric = new Jan31Prj.GenericProperty<string>();
            stringgeneric.Data = "I am String Type";
            Console.WriteLine(stringgeneric.Data);
            stringgeneric.Display<string>("StringType", "Zensar");
            //instance with float type
            GenericProperty<float> floatgeneric = new GenericProperty<float>();
            floatgeneric.Data = 5.5f;
            Console.WriteLine(floatgeneric.Data);
            floatgeneric.Display<float>("FloatType", 255.56f);
            //instance of int type
            GenericProperty<int> intgeneric = new GenericProperty<int>();
            intgeneric.Data = 35;
            Console.WriteLine(intgeneric.Data);
            intgeneric.Display<int>("IntegerType", 50);
            Console.Read();
        }
    }
}
