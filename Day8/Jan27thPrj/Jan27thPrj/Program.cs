using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Jan27thPrj
{
    #region
    interface ICustomer :ISupplier
    {
         void Print(); // only declaration
        int add(int a, int b);
        
    }

    interface ISupplier 
    {
        void Draw();
    }
    #endregion
    
    class Customer : ICustomer, ISupplier
    {
        int custno;
        public void Print()
        {
            Console.WriteLine("Interface ICustomer Implementation");
        }
        public int add(int x, int y)
        {
            return 0;
            
        }

       public void Draw()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Print();
           
        }
    }
}
