using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT02_Assertions
{
    [TestFixture]
    public class _02_Assertions
    {

        /* Assertions
        * Assertions are central to unit testing in any of the xUnit frameworks, and NUnit is no exception. 
        * NUnit provides a rich set of assertions as static methods of the Assert class.
        * 
        * If an assertion fails, the method call does not return and an error is reported.
        * If a test contains multiple assertions, any that follow the one that failed will not be executed.
        * For this reason, it's usually best to try for one assertion per test.
        * 
        * Each method may be called without a message, with a simple text message or with a message and arguments.
        * In the last case the message is formatted using the provided text and arguments.
        * 
        * Two Models
        * In NUnit 3.0, assertions are written primarily using the Assert.
        * That method, which takes constraint objects as an argument.We call this the Constraint Model of assertions
        * 
        * In earlier versions of NUnit, a separate method of the Assert class was used for each different assertion.
        * This Classic Model is still supported but since no new features have been added to it for some time, 
        * the constraint-based model must be used in order to have full access to NUnit's capabilities.
        * 
        * For example, the following code must use the constraint model.There is no real classic equivalent.
        * 
        * int[] array = { 1, 2, 3 };
        * Assert.That(array, Has.Exactly(1).EqualTo(3));
        * Assert.That(array, Has.Exactly(2).GreaterThan(1));
        * Assert.That(array, Has.Exactly(3).LessThan(100));
        * 
        * Where equivalents do exist, the two approaches will always give the same result, 
        * because the methods of the classic approach have all been implemented internally using constraints. For example...
        * 
        * Assert.AreEqual(4, 2 + 2);
        * Assert.That(2 + 2, Is.EqualTo(4));
        */

        #region True & IsTrue
        [Test]
        public void A01_True_IsTrue()
        {
            /*
             * Assert.True and Assert.IsTrue test that the specified condition is true. 
             * The two forms are provided for compatibility with past versions of NUnit and NUnitLite.
             * 
             * Assert.True(bool condition);
             * Assert.True(bool condition, string message, params object[] params);
             * 
             * Assert.IsTrue(bool condition);
             * Assert.IsTrue(bool condition, string message, params object[] params);
             */

            bool trueCondition = true;

            // True
            Assert.True(trueCondition);
            Assert.True(trueCondition, "This message will show when the condition is false.");

            // IsTrue
            Assert.IsTrue(trueCondition);
            Assert.IsTrue(trueCondition, "This message will show when the condition is false.");

        }
        #endregion

        #region False & IsFalse
        [Test]
        public void A02_False_IsFalse()
        {
            /*
             * Assert.False and Assert.IsFalse test that the specified condition is false. 
             * The two forms are provided for compatibility with past versions of NUnit and NUnitLite.
             * 
             * Assert.False(bool condition);
             * Assert.False(bool condition, string message, params object[] params);
             * 
             * Assert.IsFalse(bool condition);
             * Assert.IsFalse(bool condition, string message, params object[] params);
             */

            bool falseCondition = false;
            
            // False
            Assert.False(falseCondition);
            Assert.False(falseCondition, "This message will show when the condition is true.");

            // IsFalse
            Assert.IsFalse(falseCondition);
            Assert.IsFalse(falseCondition, "This message will show when the condition is true.");

        }
        #endregion

        [Test]
        public void A03_Null_IsNull()
        {
            
        }

        [Test]
        public void A04_NotNull_IsNotNull()
        {

        }

        [Test]
        public void A05_Zero()
        {

        }

        [Test]
        public void A06_NotZero()
        {

        }

        [Test]
        public void A07_IsNan()
        {

        }

        [Test]
        public void A08_IsEmpty()
        {

        }

        [Test]
        public void A09_IsNotEmpty()
        {

        }

        [Test]
        public void A10_AreEqual()
        {

        }

        [Test]
        public void A11_AreNotEqual()
        {

        }

        [Test]
        public void A12_AreSame()
        {

        }

        [Test]
        public void A13_AreNotSame()
        {

        }

        [Test]
        public void A14_Contains()
        {

        }

        [Test]
        public void A15_Greater()
        {

        }

        [Test]
        public void A16_GreaterOrEqual()
        {

        }

        [Test]
        public void A17_Less()
        {

        }

        [Test]
        public void A18_LessOrEqual()
        {

        }

        [Test]
        public void A19_Positive()
        {

        }

        [Test]
        public void A20_Negative()
        {

        }

        [Test]
        public void A21_IsInstanceOf()
        {

        }

        [Test]
        public void A22_IsNotInstanceOf()
        {

        }

        [Test]
        public void A23_IsAssignableFrom()
        {

        }

        [Test]
        public void A24_IsNotAssignableFrom()
        {

        }

        [Test]
        public void A25_Throws()
        {

        }

        [Test]
        public void A26_ThrowsAsync()
        {

        }

        [Test]
        public void A27_DoesNotThrow()
        {

        }

        [Test]
        public void A28_DoesNotThrowAsync()
        {

        }

        [Test]
        public void A29_Catch()
        {

        }

        [Test]
        public void A30_CatchAsync()
        {

        }

        [Test]
        public void A31_Pass()
        {

        }

        [Test]
        public void A32_Fail()
        {

        }

        [Test]
        public void A33_Ignore()
        {

        }

        [Test]
        public void A34_Inconclusive()
        {

        }

        [Test]
        public void A35_StringAssert()
        {

        }

        [Test]
        public void A36_()
        {

        }

        [Test]
        public void A37_()
        {

        }
    }
}
