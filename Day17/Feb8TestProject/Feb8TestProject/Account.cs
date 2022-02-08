using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb8TestProject
{
    public class Account
    {
        private string accountno;
        private float balance;
        public List<Account> transferaccount;

        public Account(string accno)
        {
            this.accountno = accno;
            transferaccount = new List<Account>();
            balance = 500.0f;
        }

        public float checkBalance()
        {
            return balance;
        }

        public void Deposit(float amount)
        {
            balance += amount;
           // checkBalance();
        }

        public void Withdraw(float amount)
        {
            if (balance > amount)
                balance -= amount;
           else
             throw new Exception("Not Enough Funds to withdraw..");
            //checkBalance();
        }

        public void AddTransferAccounts(Account accno)
        {
            transferaccount.Add(accno);
        }

        public void transferFunds(string destinationaccount,float amount)
        {
            Account d_account = transferaccount.Find(acc => acc.accountno == destinationaccount);
            if(d_account!=null)
            {
                d_account.Deposit(amount);
                checkBalance();
            }
        }
    }
}
