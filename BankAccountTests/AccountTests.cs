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
        public void Deposit_Positive_Amount_Balance_returnsBalance(double depositAmount)
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

        // withdrawal tests
        [TestMethod]
        // Withdraws positive amount and checks to be sure the correct amount was withdrawn
        [DataRow(100)]
        public void Withdraw_PosAmount_DecBalance(double withdrawAmount)
        {
            //arrange
            double initDeposit = 100;
            double expectedBal = initDeposit - withdrawAmount;
            //act
            acc.Deposit(initDeposit);
            acc.Withdraw(withdrawAmount);
            double actualBalance = acc.Balance;
            //assert
            Assert.AreEqual(expectedBal, actualBalance);
        }
        [TestMethod]
        //if account is overdrafted, throw argument exception
        [DataRow(-100)]
        public void Withdraw_Overdraft_ThrowsArgumentExcepetion(double withdrawAmount) 
        {
           
            Assert.ThrowsException<ArgumentOutOfRangeException>
                    (() => acc.Deposit(withdrawAmount));

        }
        [TestMethod]
        // if withdrawal amount is negative throw out of range exception
        public void Withdraw_Negative_ThrowsOutofRangeException() 
        {
            // arrange
            double withdrawAmount = -50;
            acc.Withdraw(withdrawAmount);
            // act and assert
            Assert.ThrowsException<ArgumentOutOfRangeException>
                    (() => acc.Deposit(withdrawAmount));
        }
        [TestMethod]
        //withdrays positive amount and returns decreased balance
        public void Withdraw_PosAmount_ReturnsUpBal()
        {
            double initDeposit = 100;
            double withdrawAmount = 50;
            double expectedBal = initDeposit - withdrawAmount;
            //act
            acc.Deposit(initDeposit);
            acc.Withdraw(withdrawAmount);
            double actualBalance = acc.Balance;
            //assert
            Assert.AreEqual(expectedBal, actualBalance);
        }
    }

}