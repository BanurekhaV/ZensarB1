using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb8TestProject;
using NUnit.Framework;

namespace AccountTester
{
    [TestFixture]
    public class TestAccount
    {
        //Arrange
        Account acc ;
        [SetUp]
        public void TestSetup()
        {
            acc = new Account("I-12345");
        }

        [Test]
        public void TestDeposit_Method()
        {
            //ask
            acc.Deposit(500);
            //assert
            Assert.AreEqual(1000, acc.checkBalance());
        }
        
       
        public void TestWithdraw()
        {
            //ask            
            acc.Withdraw(2100);
        }
        [Test]
        public void TestWithdrawException()
        {
            
            Assert.Throws<Exception>(TestWithdraw);
        }
        [Test]
        public void JustChecking_Balance()
        {
            Assert.AreNotEqual(1500, acc.checkBalance());
        }
    }
}
