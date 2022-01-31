using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31Prj
{
    //delegate declaration with specific signature
    public delegate void EmpHandler(string s);
    public delegate int NumChanger(int a);
    class Employee
    {
        public static void Accept(string name)
        {
            Console.WriteLine("Hello" + " " +name);
        }

        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Display()
        {
            Console.WriteLine("Welcome");
        }

        
    }

    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int Multiplynum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
    class Delegates1
    {
        static void Main()
        {
            //working with first delegate
            Employee empobj = new Employee();
            EmpHandler eh1 = new EmpHandler(Employee.Accept); //passing the name of the static function to the delegate object
            EmpHandler eh2 = new EmpHandler(empobj.Show);//passing the name of the public method to the delegate object thru the object instance
            //calling delegates
            eh1("Krithika");
            eh2.Invoke("RaviKumar");
            //working with second delegate
            NumChanger nc1 = new NumChanger(TestDelegate.AddNum);
            NumChanger nc2 = new NumChanger(TestDelegate.Multiplynum);
            //calling delegates
            nc1(25);
            Console.WriteLine("Value of Number after Addition :{0}",TestDelegate.getNum());
            nc2(5);
            Console.WriteLine("Value of Number after Multiplication :{0}", TestDelegate.getNum());
            Console.Read();
        }
    }
}
