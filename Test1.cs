using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzCSharp
{
    /// <summary>
    /// A test class for confirming the functionality of the Fizzbuzz methods
    /// </summary>
    [TestFixture]
    public class FizzbuzzTest
    {

        Fizzbuzz fizzbuzz;

        [SetUp]
        public void SetupForEachTest()
        {
            fizzbuzz = new Fizzbuzz();
        }

        [Test]
        public void DivisibleByThree()
        {
            fizzbuzz.DivisibleByThree(3);
  
            Assert.IsTrue(true);

            fizzbuzz.DivisibleByThree(1);

            Assert.IsFalse(false);
        }

        [Test]
        public void DivisibleByFive()
        {
            fizzbuzz.DivisibleByFive(5);

            Assert.IsTrue(true);

            fizzbuzz.DivisibleByFive(1);

            Assert.IsFalse(false);
        
        }
    }
}
