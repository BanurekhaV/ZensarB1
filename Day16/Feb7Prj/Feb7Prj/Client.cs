using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb7Prj
{
    class Client
    {
           static void Main(string[] args)
            {
            Console.WriteLine("enter Card Type:");
            string cardType = Console.ReadLine();

            //invoking the CreditCardFactory's method to create object and not the actual concrete class
            CreditCard carddetails = CreditCardFactory.GetCreditCard(cardType);                     
           
            if(carddetails!=null)
            {
                Console.WriteLine("CardType : "+ " "+ carddetails.GetCardType());
                Console.WriteLine("CreditLimit : " + " " + carddetails.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + " " + carddetails.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.Read();
            }
        
    }
}
