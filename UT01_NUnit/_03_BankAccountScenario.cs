using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.NUnit
{
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

        }

        public void Withdraw(decimal amount)
        {

        }

        /*
         * 
         */

        [TestFixture] 
        // TestFixture is the attribute that marks a class that contains tests and, optionally, setup or teardown methods.
        public class BankAccountTests
        {
            [Test]
            /*
             * The "Test" attribute is one way of marking a method inside a TestFixture class as a test. It is normally used 
             * for simple (non-parameterized) tests but may also be applied to parameterized tests without causing any extra 
             * testcases to be generated. See Parameterized Tests for more info.
             */
            public void P01_BankAccountShouldIncreaseOnPositiveDeposit()
            {

            }
        }
    }
}
