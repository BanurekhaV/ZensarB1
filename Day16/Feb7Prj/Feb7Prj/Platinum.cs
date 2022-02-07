using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb7Prj
{
    class Platinum:CreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharges()
        {
            return 2000;
        }
    }
}
