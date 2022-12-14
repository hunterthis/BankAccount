using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// creates an account with a specific owner
        /// </summary>
        /// <param name="accOwner"></param>
        public Account(string accOwner)
        {
            Name = accOwner;
        }
        /// <summary>
        /// account owners name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// amount of money in account
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// adds a specific amount of funds to account
        /// </summary>
        /// <param name="amt">amount deposit</param>
        /// <exception cref="NotImplementedException"></exception>
        public double Deposit(double amt)
        {
            if (amt <= 0)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(amt)} must be positive");
            }

            Balance += amt;
            return Balance;
        }
/// <summary>
/// withdraws specified amount of money from account
/// </summary>
/// <param name="amt"></param>
/// <exception cref="NotImplementedException">amount to be withdrawn</exception>
        public double Withdraw(double amt)
        {
            Balance -= amt;
            return Balance;
        }
    }
}
