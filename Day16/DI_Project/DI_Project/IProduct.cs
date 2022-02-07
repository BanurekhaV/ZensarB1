using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    interface IProduct
    {
        string InsertData();
    }

    interface IOrder
    {
        void Display();
    }

    class ML:IOrder
    {
        public void Display()
        {
            Console.WriteLine("Displaying Orders");
        }
    }
}
