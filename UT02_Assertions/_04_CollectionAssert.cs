using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UT02_Assertions
{
    /*
     * CollectionAssert
     * 
     * The CollectionAssert class provides a number of methods that are useful when examining collections and their contents 
     * or for comparing two collections. These methods may be used with any object implementing IEnumerable.
     * 
     * The AreEqual overloads succeed if the corresponding elements of the two collections are equal. 
     * AreEquivalent tests whether the collection contents are equal, 
     * but without regard to order. In both cases, elements are compared using NUnit's default equality comparison.
     */

    [TestFixture]
    public class _04_CollectionAssert
    {
        [Test]
        public void CA01_AllItemsAreInstancesOfType()
        {

        }

        [Test]
        public void CA02_AllItemsAreNotNull()
        {

        }

        [Test]
        public void CA03_AllItemsAreUnique()
        {

        }

        [Test]
        public void CA04_AreEqual()
        {

        }

        [Test]
        public void CA05_AreEquivalent()
        {

        }

        [Test]
        public void CA06_AreNotEqual()
        {

        }

        [Test]
        public void CA07_AreNotEquivalent()
        {

        }

        [Test]
        public void CA08_Contains()
        {

        }

        [Test]
        public void CA09_DoesNotContain()
        {

        }

        [Test]
        public void CA10_IsSubsetOf()
        {

        }

        [Test]
        public void CA11_IsNotSubsetOf()
        {

        }

        [Test]
        public void CA12_IsEmpty()
        {

        }

        [Test]
        public void CA13_IsNotEmpty()
        {

        }

        [Test]
        public void CA14_IsOrdered()
        {

        }
    }
}
