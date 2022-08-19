using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod]
        [DataRow(100)]
        [DataRow(.01)]
        public void Deposit_Negative_Balance_returnsBalance()
        {
            // AAA Arrange, Act, Assert

            //Arrange
            Account acc = new Account("TreeMan");
            double invalidDepositAmount = -1;
            //Act

            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.Deposit(invalidDepositAmount));
            
        }
        public void Positive_Amount_Balance_returnsBalance() 
        {
            Account acc = new Account("TreeMan");
            acc.Deposit(100);
            Assert.AreEqual(100, acc.Balance); 
        }
    }
}