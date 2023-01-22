using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.NUnit
{
    /*
     * So let's suppose that we written a bunch of tests and we want to run those tests.
     * On Visual Studio Search "Test Explorer" and open the Test Explorer Window.
     */
    [TestFixture] 
    /* TestFixture : 
     * This is the attribute that marks a class that contains tests and, optionally, setup or teardown methods.
     */
    public class _02_UnitTestRunners
    {
        [Test]
        /*
         * The Test attribute is one way of marking a method inside a TestFixture class as a test. It is normally used for 
         * simple (non-parameterized) tests but may also be applied to parameterized tests without causing any extra test 
         * cases to be generated.
         */
        public void T01_FirstTest()
        {
            // That assertion will pass the test.
            Assert.Pass("Pass the test");
        }
    }
}
