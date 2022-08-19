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
        public void DefaultAccountCreation()
        {
            acc = new Account("TreeMan");
        }
        [TestMethod]
        
        [DataRow(0)]
        [DataRow(-1)]
        
        public void Deposit_Negative_Balance_returnsBalance(double depositAmount)
        {
            // AAA Arrange, Act, Assert

            //Arrange
            //Act
            //Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>
                    (() => acc.Deposit(depositAmount));
            
        }
        [TestMethod]


        public void Positive_Amount_Balance_returnsBalance()
        {
            // Arrange
            Account acc = new Account("TreeMan");
            // Act
            acc.Deposit(100);
            //Assert
            Assert.AreEqual(100, acc.Balance);
        }
        [TestMethod]
        public void Deposit_Positive_amount()
        {
            double depositAmount = 100;
            Account acc = new("TreeMan");
            acc.Deposit(depositAmount);
            Assert.AreEqual(depositAmount, acc.Balance);
        }
        public void Deposit_Zero_orLess_ThrowsArgumentException() 
        {
            //Arrange
            Account acc = new Account("TreeMan");
            //Act and //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acc.Deposit(0));
        
        }
    }
}