using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT02_Assertions
{
    /*
     * Arrange | Act | Assert (AAA)
     * 
     * Arrange-Act-Assert is a great way to structure test cases. It prescribes an order of operations:
     * 
     * Arrange inputs and targets. Arrange steps should set up the test case. Does the test require any objects or 
     * special settings? Does it need to prep a database? Does it need to log into a web app? Handle all of these 
     * operations at the start of the test.
     * 
     * Act on the target behavior. Act steps should cover the main thing to be tested. This could be calling a 
     * function or method, calling a REST API, or interacting with a web page. Keep actions focused on the target 
     * behavior.
     * 
     * Assert expected outcomes. Act steps should elicit some sort of response. Assert steps verify the goodness or 
     * badness of that response. Sometimes, assertions are as simple as checking numeric or string values. Other 
     * times, they may require checking multiple facets of a system. Assertions will ultimately determine if the test 
     * passes or fails.
     */

    public class BankAccount
    {
        // Balance of the Bank Account
        public decimal Balance { get; private set; }

        public BankAccount(decimal startingBalance)
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
    public class _08_ArrangeActAssert
    {
        private BankAccount ba;

        [SetUp]
        public void SetupOne()
        {
            // Arrange
            ba = new BankAccount(100);
        }

        [Test]
        public void BankAccountTests()
        {
            // Arrange
            // var ba = new BankAccount(100);

            // Act
            ba.Deposit(100);

            // Assert
            Assert.That(ba.Balance, Is.EqualTo(200));
        }
    }
}
