using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        // Test method requirements:
        //      Method must be decorated with the [TestMethod] attribute
        //      Method must return void
        //      Method cannot have parameters 

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            account.Debit(debitAmount);

            double actual = account.Balance;

            // AreEqual method verifies that value is what is expected
            // Part of the unit test framework https://msdn.microsoft.com/en-us/library/ms243456.aspx
            Assert.AreEqual(expected, actual, 0.001, "Accuont not debited correctly");
        }

        // tests to make sure an exception is thrown when a debit amount is below zero (a negative debit)
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            account.Debit(debitAmount);

        }

        // I made, not part of tutorial
        // checks to make sure an exception is thrown when a debit amount is greater than the current account balance 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 100.00;
            double debitAmount = 200.00;
            BankAccount account = new BankAccount("Johnny Appleseed", beginningBalance);

            account.Debit(debitAmount);
        }

        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount less than zero";


    }
}
