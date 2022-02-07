using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if(creditCard!=null)
            {
                Console.WriteLine("CardType : " + " " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + " " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + " " + creditCard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------");
            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("CardType : " + " " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + " " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + " " + creditCard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------");

            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("CardType : " + " " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + " " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + " " + creditCard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------");
            Console.Read();
        }
    }
}
