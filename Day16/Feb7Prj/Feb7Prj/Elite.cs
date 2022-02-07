using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb7Prj
{
    class Elite:CreditCard
    {
        public string GetCardType()
        {
            return "Elite";
        }
        public int GetCreditLimit()
        {
            return 45000;
        }
        public int GetAnnualCharges()
        {
            return 2500;
        }
    }
}
