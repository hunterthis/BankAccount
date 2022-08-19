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
        public void Withdraw_PosAmount_DecBalance()
        {
            //arrange
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
        //withdrays positive amount and returns decreased balance
        public void Withdraw_PosAmount_ReturnsUpBal() 
        {
            Assert.Fail();
        }
        //if account is overdrafted, throw argument exception
        public void Withdraw_Overdraft_ThrowsArgumentExcepetion() 
        {
            Assert.Fail();
        }
        // if withdrawal amount is negative throw out of range exception
        public void Withdraw_Negative_ThrowsOutofRangeException() 
        {
            Assert.Fail();
        }
    }

}