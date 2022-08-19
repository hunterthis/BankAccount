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
        private Account acc;
        [TestInitialize]
        private void DefaultAccountCreation()
        {
            acc = new Account("TreeMan");
        }
        [TestMethod]
        [DataRow(100)]
        [DataRow(.01)]
        [DataRow()]
        [DataRow(1.99)]
        [DataRow(9999.99)]
        public void Deposit_Negative_Balance_returnsBalance()
        {
            // AAA Arrange, Act, Assert

            //Arrange
            double invalidDepositAmount = -1;
            //Act

            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.Deposit(invalidDepositAmount));

        }
        [TestMethod]
        public void Positive_Amount_Balance_returnsBalance()
        {
            // Arrange
            // Act
            acc.Deposit(100);
            //Assert
            Assert.AreEqual(100, acc.Balance);
        }
        [TestMethod]
        public void Deposit_Positive_amount(double depositAmount)
        {
            acc.Deposit(depositAmount);
            Assert.AreEqual(depositAmount, acc.Balance);
        }
        public void Deposit_Zero_orLess_ThrowsArgumentException() 
        {
            //Arrange
            //Act and //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acc.Deposit(0));
        
        }
    }
}