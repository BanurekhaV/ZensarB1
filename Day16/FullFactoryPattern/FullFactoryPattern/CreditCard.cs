using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFactoryPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharges();
    }

    public class MoneyBack:CreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharges()
        {
            return 500;
        }
    }

    class Titanium : CreditCard
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

    class Platinum : CreditCard
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
