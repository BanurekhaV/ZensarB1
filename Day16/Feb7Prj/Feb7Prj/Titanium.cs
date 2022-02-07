using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb7Prj
{
    class Titanium :CreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharges()
        {
            return 1000;
        }
    }
}
