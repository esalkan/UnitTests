using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT03_TestingMethodologies
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
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));
            }

            Balance = Balance + amount;
        }

        public bool Withdraw(decimal amount)
        {
            return false;
        }
    }

    [TestFixture]
    public class _01_DataDrivenTesting
    {
        private BankAccount ba;

        [SetUp]
        public void SetUp()
        {
            ba = new BankAccount(100);
        }

        [Test]
        [TestCase(50, true,50)]
        [TestCase(100, true, 0)]
        [TestCase(1000, false, 100)]
        public void TestMultipleWithdrawalScenarios(
            int amountToWithdraw, bool shouldSucceed, int expectedBalance)
        {
            var result = ba.Withdraw(amountToWithdraw);
            // Warn.If(!result, "Failed for some reason");

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(shouldSucceed));
                Assert.That(expectedBalance, Is.EqualTo(ba.Balance));
            });
        }
    }
}
