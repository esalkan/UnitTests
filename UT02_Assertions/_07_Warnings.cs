using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT02_Assertions
{
    /*
     * Warnings
     * Sometimes - especially in integration testing - it's desirable to give a warning message but continue 
     * execution. Beginning with release 3.6, NUnit supports this with the Warn class and the Assert.Warn method.
     */

    [TestFixture]
    public class _07_Warnings
    {
        [Test]  
        public void W01_Warn_If()
        {
            // Using Warn With Reversed Condition
            Warn.If(2 + 2 != 5);
            Warn.If(()=> 2 + 2 != 5);
            Warn.If(2 + 2, Is.Not.EqualTo(5));
            Warn.If(()=> 2 + 2, Is.Not.EqualTo(5));
            Warn.If(()=> 2 + 2, Is.Not.EqualTo(5).After(500));
        }

        [Test]
        public void W02_Warn_Unless()
        {
            // Using Warn With Original Condition
            Warn.Unless(2 + 2 == 5);
            Warn.Unless(() => 2 + 2 == 5);
            Warn.Unless(2 + 2, Is.EqualTo(5));
            Warn.Unless(() => 2 + 2, Is.EqualTo(5));
            Warn.Unless(() => 2 + 2, Is.EqualTo(5).After(500));
        }

        [Test]
        public void W03_Assert_Warn()
        {
            // Issue a warning message
            Assert.Warn("Warning message");
        }

        /*
         * Each of the above items would fail. The test would continue to execute, however, and the warning messages 
         * would only be reported at the end of the test. If the test subsequently fails, the warnings will be 
         * reported along with the failure message or - in the case of Assert.Multiple - messages.
         */
    }
}
