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
        public Account acc;
        [TestInitialize]
        public void DefaultAccountCreation()
        {
            acc = new Account("TreeMan");
        }
        [TestMethod]
        [DataRow(-1)]
        public void Deposit_Negative_Balance_returnsBalance(double depositAmount)
        {
                Assert.ThrowsException<ArgumentOutOfRangeException>
                    (() => acc.Deposit(depositAmount));
            
        }
        [TestMethod]
        [DataRow(100)]
        public void Positive_Amount_Balance_returnsBalance(double depositAmount)
        {
            acc.Deposit(depositAmount);
            Assert.AreEqual(depositAmount, acc.Balance);
        }
        [TestMethod]
        [DataRow(100)]
        public void Deposit_Positive_amount(double depositAmount)
        {
            acc.Deposit(depositAmount);
            Assert.AreEqual(depositAmount, acc.Balance);
        }
        [TestMethod]
        [DataRow(0)]
        public void Deposit_Zero_ThrowsArgumentException(double depositAmount) 
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.Deposit(0));
        
        }
    }
}