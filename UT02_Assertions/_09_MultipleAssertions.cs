using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT02_Assertions
{
    public class BankAccount1
    {
        // Balance of the Bank Account
        public decimal Balance { get; private set; }

        public BankAccount1(decimal startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(decimal amount)
        {

        }
    }

    [TestFixture]
    public class _09_MultipleAssertions
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
        public void MultipleAssertion()
        {
            // Arrange
            

            // Act
            ba.Withdraw(100);

            // Assert
            /* Below lines will give error. First one will give error and the test
             * will marked fail to solve that issue and make Multiple Assertions
             * Assert.That(ba.Balance, Is.EqualTo(0));
             * Assert.That(ba.Balance, Is.LessThan(1));
             */

            Assert.Multiple(()=>
            {
                Assert.That(ba.Balance, Is.EqualTo(0));
                Assert.That(ba.Balance, Is.EqualTo(100)); // This is passing.
                Assert.That(ba.Balance, Is.LessThan(1));
            });
        }
    }
}
