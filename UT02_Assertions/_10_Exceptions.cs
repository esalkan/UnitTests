using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT02_Assertions
{
    public class BankAccount2
    {
        // Balance of the Bank Account
        public decimal Balance { get; private set; }

        public BankAccount2(decimal startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));
            }

            Balance = Balance + amount;
        }

        public void Withdraw(decimal amount)
        {

        }
    }

    [TestFixture]
    internal class _10_Exceptions
    {
        private BankAccount1 ba;

        /*
         * The SetUp attribute means that whenever we run any test this method
         * gets called before the test is actually run.
         */
        [SetUp]
        public void SetupOne()
        {
            // Arrange
            ba = new BankAccount1(100);
        }

        [Test]
        public void E01_Exceptions()
        {
            // Arrange
            // Act
            // Assert
        }

        [Test]
        public void E02_BankAccountShouldThrowOnNonPositiveAmount()
        {
            // Arrange

            // Act
            //ba.Deposit(-1);

            // Assert
            var ex = Assert.Throws<ArgumentException>(
                ()=> ba.Deposit(-1)
                );

            StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        }
    }
}
