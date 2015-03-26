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
            Assert.IsTrue(fizzbuzz.DivisibleByThree(3));
            Assert.IsFalse(fizzbuzz.DivisibleByThree(1));
        }

        [Test]
        public void DivisibleByFive()
        {
            Assert.IsTrue(fizzbuzz.DivisibleByFive(5));
            Assert.IsFalse(fizzbuzz.DivisibleByFive(1));
        }

        [Test]
        public void DivisibleByThreeAndFive()
        {
            Assert.IsTrue(fizzbuzz.DivisibleByThreeAndFive(15));
            Assert.IsFalse(fizzbuzz.DivisibleByThreeAndFive(3));
        }
        [Test]
        [Ignore ("Can't quite get the test right for this")]
        public void Plays()
        {
            Assert.Contains(fizzbuzz.Plays(15), Is.StringContaining("Fizzbuzz"));
        }
    }
}
