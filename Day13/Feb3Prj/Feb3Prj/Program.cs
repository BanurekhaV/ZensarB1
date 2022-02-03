using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Program
    {
        int data;
        public int Age { get; }
        public string Name { get; } = "John";
        public string Address { get; set; }
        public double Salary { get; } = 65000;
        public float Incentive { get; protected set; }
        public string CompanyName { get; private set; }
        public Program()
        {
            Age = 25;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1 = new Program();
            p.CompanyName = "NewZensar";
            p.data = 55;
            Console.WriteLine(p.Incentive + p.Name + p.Salary +p.Age);
            Object o = new object();
            Type t = o.GetType();
            Type t1 = p.GetType();
            Type t2 = p1.GetType();
            Console.WriteLine("Type is {0}", t);
            Console.WriteLine("HashCode is :{0}",t.GetHashCode());
            Console.WriteLine("Type of Program: {0}",t1);
            Console.WriteLine("Hash Code of Program p and p1 {0}, {1}",t1.GetHashCode(),t2.GetHashCode());
            Console.Read();

        }
    }
}
