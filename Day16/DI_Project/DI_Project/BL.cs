using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class BL
    {
        private IProduct objprod;
        IOrder objord;

        public BL(IProduct ip,IOrder io) //injecting the type object that implements the Interface Object
        {
            objprod = ip;
            objord = io;

        }

        public void Insert()
        {
            objprod.InsertData();//actually the call will be for DL.InsertData(),
                                 //but through the IProduct object
            objord.Display();
        }
    }
}
