using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    class MyGenericClass<T> 
    {
        private T genericDataMember;

        public T genericProperty { get; set; }
        public MyGenericClass(T data)
        {
            genericDataMember = data;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type is: {0}, and the Value is :{1}",typeof(T).ToString(),genericParameter);
            Console.WriteLine("Field Type Type is :{0}, and the value is :{1}", typeof(T).ToString(),genericDataMember);
            return genericDataMember;
        }
    }
    class AllGenerics
    {
        static void Main()
        {
            MyGenericClass<int> mygenericInt = new MyGenericClass<int>(20);
            int returnvalue = mygenericInt.genericMethod(200);
            Console.WriteLine(returnvalue);

            MyGenericClass<string> mygenericstring = new MyGenericClass<string>("Hello Generics");
            string s = mygenericstring.genericMethod("Invoking Method with string type");
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
