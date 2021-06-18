using System;
using NUnit.Framework;


namespace PrimeNumbers.Tests
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        private PrimeNumbers primeNumbers;

        [SetUp]
        public void TestInitialize()
        {
            primeNumbers = new PrimeNumbers();
        }

        [TearDown]
        public void TestCleanup()
        {
            primeNumbers = null;
        }
        
        [Test]
        public void TestMethod1()
        {
            var result = primeNumbers.GetNextPrimeNumber(1);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestMethod2()
        {
            var result = primeNumbers.GetNextPrimeNumber(7907);
            Assert.AreEqual(7919, result);
        }

        [Test]
        public void TestMethod3()
        {
            var result = primeNumbers.GetNextPrimeNumber(199811);
            Assert.AreEqual(199813, result);
        }

        [Test]
        public void TestMethod4()
        {
            var result = primeNumbers.GetNextPrimeNumber(999979);
            Assert.AreEqual(999983, result);
        }
    }
}
